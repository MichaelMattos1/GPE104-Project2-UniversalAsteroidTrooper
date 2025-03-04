using UnityEngine;

public class Damage : MonoBehaviour
{
    
    public float damageAmount = 25;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

       if (collision.gameObject.TryGetComponent<HealthTracker>(out HealthTracker component ))
        {
            component.TakeDamage(damageAmount);
        }
            
    } 
}
