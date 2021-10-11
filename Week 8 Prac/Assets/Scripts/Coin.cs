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
            scoreKeeper.pickupCoin(other.tag);
            Destroy(this.gameObject);
        }
        if(other.CompareTag("Player2"))
        {
            scoreKeeper.pickupCoin(other.tag);
            Destroy(this.gameObject);
        }
    }
}
