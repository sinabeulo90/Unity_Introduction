using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TileScreen : MonoBehaviour
{
    public GUIStyle labelStyle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            SceneManager.LoadScene("Main");
        }
    }

    private void OnGUI()
    {
        int sw = Screen.width;
        int sh = Screen.height;
        GUI.Label(new Rect(0, sh / 4, sw, sh / 4), "BALL MAZE", labelStyle);
        GUI.Label(new Rect(0, sh / 2, sw, sh / 4), "Hit Space Key", labelStyle);
    }
}
