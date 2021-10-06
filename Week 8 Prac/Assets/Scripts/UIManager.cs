using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    ScoreKeeper scoreScript;
    Text scoreObject;
    // Start is called before the first frame update
    void Start()
    {
        scoreScript = GameObject.FindObjectOfType<ScoreKeeper>();
        scoreObject = Transform.FindObjectOfType<Text>(); //Find Text component in Score, which is child of the Canvas
    }

    // Update is called once per frame
    void Update()
    {
        scoreObject.text = "Current Score = " + scoreScript.currentScore;
    }
}
