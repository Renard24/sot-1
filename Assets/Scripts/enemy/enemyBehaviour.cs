using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehaviour : MonoBehaviour
{
    private Shooter2D shooter;

    private void Start()
    {
        shooter = GetComponent<Shooter2D>();
        InvokeRepeating(nameof(Shoot), 0, 1f);
    }

    private void Shoot()
    {
        shooter.Shoot();
    }
}
