using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    // Start is called before the first frame update
    private PlayerMovement player;
    private GameOverManager gameOverManager;
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
        gameOverManager = GameObject.FindWithTag("Player").GetComponent<GameOverManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.isAlive == false)
        {
            gameOverManager.GameOver();
        }
    }
}
