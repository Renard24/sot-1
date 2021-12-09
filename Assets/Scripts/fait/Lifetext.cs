using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Lifetext : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    private PV PV;

    private void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        PV = GetComponentInParent<PV>();
    }
    public void UpdateLife()
    {
        textMesh.text = PV.currentHealth.ToString();
    }
   
}
