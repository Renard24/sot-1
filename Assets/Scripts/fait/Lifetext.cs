using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Lifetext : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    private PVPlayer PV;

    private void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        PV = FindObjectOfType<PVPlayer>();
    }
    public void Update()
    {
        textMesh.text = PV.currentHealth.ToString();
    }
   
}
