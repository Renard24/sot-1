using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] public float timeToDestroy;

    void Start()
    {
        Destroy(this.gameObject, timeToDestroy);
    }


    void Update()
    {
        
    }
}
