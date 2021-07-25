using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private bool cleared;
    private int ballCount;
    private int counter;

    public GUIStyle labelStyle;

    // Start is called before the first frame update
    void Start()
    {
        ballCount = GameObject.FindGameObjectsWithTag("Ball").Length;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            ++counter;
            if (cleared == false && counter == ballCount)
            {
                cleared = true;
                StartCoroutine(waiter());
                SceneManager.LoadScene("Title");
            }
        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(2.0F);
        Debug.Log("2 seconds");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            --counter;
        }
    }

    private void OnGUI()
    {
        if (cleared == true)
        {
            int sw = Screen.width;
            int sh = Screen.height;
            GUI.Label(new Rect(sw / 6, sh / 3, sw * 2 / 3, sh / 3), "CLEARED!!", labelStyle);
        }
    }
}
