using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public int pickupPoints = 2;

    [HideInInspector]
    public int currentScore;
    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void pickupCoin()
    {
        currentScore += pickupPoints;
    }

}
