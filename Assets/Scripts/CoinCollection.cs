using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CoinCollection : MonoBehaviour
{
    int NumOfCoins;
    int i = 1;
    public int playerHealth = 3;
    public GameObject[] hearts;
    public TMP_Text CoinNumText;

    private PlayerMovement player;
    private void Start()
    {
        CoinNumText.text = "X" + NumOfCoins.ToString();
        player = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            NumOfCoins += 1;
            CoinNumText.text = "X" + NumOfCoins.ToString();
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("Spike"))
        {
            takeDamage();
        }
        else if (collision.CompareTag("PowerUp"))
        {
            GainHealth();
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("TreasureBox"))
        {
            CollectTreasureBox();
            Destroy(collision.gameObject);
        }
    }

    public void takeDamage()
    {
        if (playerHealth > 0)
        {
            playerHealth -= 1;
            hearts[hearts.Length - i].gameObject.SetActive(false);
            i++;
            if (playerHealth <= 0)
            {
                player.isAlive = false;
            }
        }
    }

    private void GainHealth()
    {
        if (playerHealth < 3)
        {
            playerHealth += 1;
            i--;
            hearts[hearts.Length - i].gameObject.SetActive(true);
        }
    }

    private void CollectTreasureBox()
    {
        NumOfCoins += 10;
        CoinNumText.text = "X" + NumOfCoins.ToString();
    }
}
