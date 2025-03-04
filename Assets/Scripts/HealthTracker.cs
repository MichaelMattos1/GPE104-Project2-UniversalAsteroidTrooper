using UnityEngine;

public class HealthTracker : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;

    public Death deathComponent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        deathComponent = GetComponent<Death>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Heal(float amount)
    {
        currentHealth += amount;

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
    }

    public void TakeDamage(float amount)
    {
        currentHealth = currentHealth - amount;

        if (currentHealth <= 0)
        {
            print("You Died");
            deathComponent.Die();
        }

    }


    public bool IsAlive()
    {
        if (currentHealth >  0) return true;

        return false;
    }
}
