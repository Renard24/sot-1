using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehaviour : MonoBehaviour
{
    private Shooter2D shooter;

    private void Start()
    {
        shooter = GetComponent<Shooter2D>();
        InvokeRepeating(nameof(Shoot), 0, 0.4f);
    }

    private void Shoot()
    {
        shooter.Shoot();
    }
}
