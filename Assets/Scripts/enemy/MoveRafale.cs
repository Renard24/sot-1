using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRafale : MonoBehaviour
{
    public float VitesseRafale;
    Rigidbody2D RigidBodyRafale;
    // Start is called before the first frame update
    void Start()
    {
        RigidBodyRafale = GetComponent<Rigidbody2D>();
        RigidBodyRafale.velocity = transform.forward * -1 * VitesseRafale;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
