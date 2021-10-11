using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public ScoreKeeper scoreScript;
    public Text playerOneScore;
    public Text playerTwoScore;

    // Update is called once per frame
    void Update()
    {
        playerOneScore.text = "Player 1 Score: " + scoreScript.playerOneScore;
        playerTwoScore.text = "Player 2 Score: " + scoreScript.playerTwoScore;
    }
}
