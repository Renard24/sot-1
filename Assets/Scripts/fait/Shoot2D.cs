using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot2D : MonoBehaviour
{
    public GameObject bullet;
    public Vector2 direction;
    public float bulletSpeed;

    public void Shoot()
    {
        var instantiatedBullet = Instantiate(bullet, transform.position, Quaternion.identity);
        var bulletMove = instantiatedBullet.GetComponent<Move2D>();
        bulletMove.direction = direction;
        bulletMove.speed = bulletSpeed;
    }
}
