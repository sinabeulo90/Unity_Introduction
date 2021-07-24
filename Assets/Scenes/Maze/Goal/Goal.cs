using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private bool cleared;
    private int ballCount;
    private int counter;

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
                Debug.Log("Cleared!");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            --counter;
        }
    }
}
