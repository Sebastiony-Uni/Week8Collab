using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    ScoreKeeper scoreKeeper;

    // Start is called before the first frame update
    void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // if collision with player
        if(other.CompareTag("Player"))
        {
            scoreKeeper.pickupCoin();
            Destroy(this.gameObject);
        }
    }
}
