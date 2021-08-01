using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Scorekeeper))]

public class ResultScreen : MonoBehaviour
{
    public GUISkin skin;

    private Scorekeeper scorekeeper;
    private string state;

    // Start is called before the first frame update
    void Start()
    {
        scorekeeper = GetComponent<Scorekeeper>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TimeUp()
    {
        StartCoroutine(_TimeUp());
    }

    IEnumerator _TimeUp()
    {
        state = "Time Up";
        yield return new WaitForSeconds(3.0F);

        state = "";
        yield return new WaitForSeconds(0.5F);

        state = "Show Score";
        yield return new WaitUntil(() => Input.GetButtonDown("Fire1"));

        SceneManager.LoadScene("Main");
    }

    private void OnGUI()
    {
        int sw = Screen.width;
        int sh = Screen.height;

        GUI.skin = skin;
        if (state == "Time Up")
        {
            GUI.Label(new Rect(0, 0, sw, sh), "Time Up!!", "message");
        }
        else if (state == "Show Score")
        {
            string scoreText = "Your score is " + scorekeeper.score.ToString();
            GUI.Label(new Rect(0, sh / 4, sw, sh / 4), scoreText, "message");
            GUI.Label(new Rect(0, sh / 2, sw, sh / 4), "Click to Exit", "message");
        }
    }


}
