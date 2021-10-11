using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public ScoreKeeper scoreScript;
    public Text scoreObject;

    // Update is called once per frame
    void Update()
    {
        scoreObject.text = "Current Score: " + scoreScript.currentScore;
    }
}
