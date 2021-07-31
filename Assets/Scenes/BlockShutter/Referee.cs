using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Scorekeeper))]

public class Referee : MonoBehaviour
{
    public float switchInterval;
    public int rewardPoint;
    public int penaltyPoint;

    private Scorekeeper scorekeeper;
    private bool targetIsRed;
    private float switchTimer;

    private string GetTargetColorName()
    {
        return targetIsRed ? "Red" : "Blue";
    }

    // Start is called before the first frame update
    void Start()
    {
        scorekeeper = GetComponent<Scorekeeper>();
        targetIsRed = true;
        switchTimer = switchInterval;
    }

    // Update is called once per frame
    void Update()
    {
        switchTimer -= Time.deltaTime;
        if (switchTimer < 0.0)
        {
            targetIsRed = !targetIsRed;
            switchTimer = switchInterval;
        }
    }

    void OnDestroyBox(string boxColorName)
    {
        if (boxColorName == GetTargetColorName())
        {
            scorekeeper.score += rewardPoint;
        }
        else
        {
            scorekeeper.score -= penaltyPoint;
        }
    }

    private void OnGUI()
    {
        if (switchTimer < 1.5) return;
        int sw = Screen.width;
        int sh = Screen.height;
        string message = "Shoot " + GetTargetColorName() + " Boxes";
        GUI.color = targetIsRed ? Color.red : Color.blue;
        GUI.Label(new Rect(0, sh / 4, sw, sh / 2), message);
    }
}
