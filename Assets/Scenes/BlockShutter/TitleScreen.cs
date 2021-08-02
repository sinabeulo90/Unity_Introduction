using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    public GUISkin skin;

    private void Awake()
    {
        Screen.autorotateToPortrait = false;
        Screen.autorotateToPortraitUpsideDown = false;
        Screen.autorotateToLandscapeRight = false;
        Screen.autorotateToLandscapeLeft = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene("Main");
        }
    }

    private void OnGUI()
    {
        int sw = Screen.width;
        int sh = Screen.height;
        GUI.skin = skin;
        GUI.Label(new Rect(0, 0, sw, sh), "B L O C K S H O O T E R", "message");
        GUI.Label(new Rect(0, sh / 2, sw, sh / 2), "Click to Start", "message");
    }
}
