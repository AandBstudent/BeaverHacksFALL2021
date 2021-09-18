using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }
        if (currentHealth < maxHealth && currentHealth >= 0)
        {
            currentHealth += 1 * Time.deltaTime ;
        }
        
        healthBar.SetHealth(currentHealth);

        if(currentHealth < 0)
        {
            // Game Over
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    void TakeDamage(float damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
