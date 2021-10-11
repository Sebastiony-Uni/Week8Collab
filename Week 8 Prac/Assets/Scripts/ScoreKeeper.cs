using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public int pickupPoints = 2;

    [HideInInspector]
    public int playerOneScore;
    public int playerTwoScore;
    // Start is called before the first frame update
    void Start()
    {
        playerOneScore = 0;
        playerTwoScore = 0;
    }

    public void pickupCoin(string tag)
    {
        if(tag == "Player")
        {
            playerOneScore += pickupPoints;
        }
        if (tag == "Player2")
        {
            playerTwoScore += pickupPoints;
        }
    }

}
