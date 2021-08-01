using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    [HideInInspector]
    public int score;

    public GUISkin skin;

    private void OnGUI()
    {
        GUI.skin = skin;
        int sw = Screen.width;
        int sh = Screen.height;
        string scoreText = "SCORE: " + score.ToString();
        GUI.Label(new Rect(0, 0, sw / 2, sh / 4), scoreText, "score");
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
