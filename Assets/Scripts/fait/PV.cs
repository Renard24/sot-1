using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PV : MonoBehaviour
{
    public int maxHealth;
    public int startingHealth;
    public UnityEvent damageTaken;

    public LayerMask mask;

    [HideInInspector] public int currentHealth;
  
    private void Start()
    {
        currentHealth = startingHealth;
    }

    private void TakeDamage()
    {

        ModifyHealth(-1);
        damageTaken.Invoke();
        if (currentHealth <= 0)
            Destroy(gameObject);

      
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(mask==(mask|(1<<col.gameObject.layer)))
            TakeDamage();  

    }
    
    private void ModifyHealth(int modifier)
    {
        currentHealth = Mathf.Clamp(currentHealth + modifier, 0, maxHealth);
    }


}
