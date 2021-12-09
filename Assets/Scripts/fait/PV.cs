using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PV : MonoBehaviour
{
    public int maxHealth;
    public int startingHealth;
    public UnityEvent damageTaken;

    [HideInInspector] public int currentHealth;
  
    private void start()
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

    private void OnCollisionEnter2D()
    {
        TakeDamage();  
    }

    private void ModifyHealth(int modifier)
    {
        currentHealth = Mathf.Clamp(currentHealth + modifier, 0, maxHealth);
    }
}
