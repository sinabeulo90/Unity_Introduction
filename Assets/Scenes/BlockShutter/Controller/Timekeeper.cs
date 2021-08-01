using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timekeeper : MonoBehaviour
{
    public float gameLength;
    private float elapsed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed > gameLength)
        {
            BroadcastMessage("TimeUp");
            GameObject.FindWithTag("MainCamera").SendMessage("TimeUp");
            enabled = false;
        }   
    }

    void StartGame()
    {
        enabled = true;
    }
}
