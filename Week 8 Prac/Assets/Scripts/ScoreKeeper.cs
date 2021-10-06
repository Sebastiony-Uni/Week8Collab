using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public int pickupPoints = 2;

    [HideInInspector]
    public int currentScore;


    float time;
    float every = 5;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        currentScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(time >= every)
        {
            currentScore+= pickupPoints;
            time = 0;
        }
    }

    public void pickupCoin()
    {
        currentScore += pickupPoints;
    }

}
