using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    private bool hasDealtDamage = false;  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !hasDealtDamage)
        {
            CoinCollection marioHealth = collision.GetComponent<CoinCollection>();
            if (marioHealth != null)
            {
                marioHealth.takeDamage();  
                hasDealtDamage = true;  
                Destroy(gameObject);  
            }
        }
    }
}
