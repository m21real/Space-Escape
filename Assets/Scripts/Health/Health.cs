using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [Header ("Health")]
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private bool dead;

    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(float _damage)
    {
        Debug.Log("-1 Health");
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            // player hurt
        }
        else
        {
            if (!dead)
            {
                Debug.Log("Player died!");
                if (GetComponent<PlayerMovement>() != null)
                GetComponent<PlayerMovement>().enabled = false;

                if (GetComponent<MeleeEnemy>() != null)
                    GetComponent<MeleeEnemy>().enabled = false;
                dead = true;
            }
        }
    }

    public void AddHealth(float _value)
    {
        Debug.Log("+1 Health");
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }
}
