using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lifetext : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    private LifeBehaviour PV;

    private void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        PV = FindObjectOfType<LifeBehaviour>();
    }
    public void Update()
    {
        textMesh.text = PV.currentHealth.ToString();
    }
   
}
