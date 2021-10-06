using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    ScoreKeeper scoreScript;
    // Start is called before the first frame update
    void Start()
    {
        scoreScript = GameObject.FindObjectOfType<ScoreKeeper>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
