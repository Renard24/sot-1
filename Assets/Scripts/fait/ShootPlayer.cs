using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

public class ShootPlayer : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletEquipage;
   
    
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(bulletEquipage, shootingPoint.position, transform.rotation);
        }
    }
}
