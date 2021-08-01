using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxGenerator : MonoBehaviour
{
    public float interval;
    public GameObject redBoxPrefab;
    public GameObject blueBoxPrefab;

    private bool nextIsRed;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        nextIsRed = true;
        timer = 0.0F;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0.0F)
        {
            float offsx = Random.Range(-8.0F, 8.0F);
            float offsz = Random.Range(-4.0F, 4.0F);
            Vector3 position = transform.position + new Vector3(offsx, 0, offsz);

            GameObject prefab = nextIsRed ? redBoxPrefab : blueBoxPrefab;
            Instantiate(prefab, position, Random.rotation);

            timer = interval;
            nextIsRed = !nextIsRed;
        }
    }

    void TimeUp()
    {
        enabled = false;
    }

    void StartGame()
    {
        enabled = true;
    }
}
