using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int playerScore;
    public Ball ball;

    public Text playerScoreText;

    public void PlayerScores()
    {
        playerScore++;
        this.playerScoreText.text = playerScore.ToString();
        //this.ball.ResetPosition();
    }

    public void PlayerLose()
    {
        playerScore = 0;
        this.playerScoreText.text = playerScore.ToString();
        this.ball.ResetPosition();
    }

 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
      //  if (playerScore > 3)
      //  {
       //     Application.LoadLevel("End");
      //  }
    }
}
