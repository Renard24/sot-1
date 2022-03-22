using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rafale : MonoBehaviour
{
    private bool hasShot;
    private Shooter2D shooter;
    public float Time;
    public int Repet;

    private void Awake()
    {
        shooter = GetComponent<Shooter2D>();
    }


    private void Update()
    {
        if(!hasShot && transform.position.y < 52)
        {
            StartCoroutine(RafaleTest());
            hasShot = true;
        }
    }

    private IEnumerator RafaleTest()
    {
       
        for (int i = 0; i < Repet; i++)
        {
            shooter.Shoot();
            yield return new WaitForSeconds(Time);
        }
    }
}
