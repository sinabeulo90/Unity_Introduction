using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    public GUISkin skin;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 3.5F;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0.0F)
        {
            BroadcastMessage("StartGame");
            enabled = false;
        }
    }

    private void OnGUI()
    {
        if (timer > 3.0F || timer <= 0.0F) return;
        int sw = Screen.width;
        int sh = Screen.height;
        string text = Mathf.CeilToInt(timer).ToString();
        GUI.skin = skin;
        GUI.color = new Color(1, 1, 1, timer - Mathf.FloorToInt(timer));
        GUI.Label(new Rect(0, sh / 4, sw, sh / 2), text, "message");
    }
}
