using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    [HideInInspector]
    public int score;

    private void OnGUI()
    {
        int sw = Screen.width;
        int sh = Screen.height;
        string scoreText = "SCORE: " + score.ToString();
        GUI.Label(new Rect(0, 0, sw / 2, sh / 4), scoreText);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
