using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManaging : MonoBehaviour
{
    public Text scoreText;
    public Text livesText;
    public Text gameOverText;

    PlayerMovement player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + player.score;
        livesText.text = "Lives: " + player.lives;

        if(player.lives <= 0)
        {
            gameOverText.gameObject.SetActive(true);
        }
    }
}
