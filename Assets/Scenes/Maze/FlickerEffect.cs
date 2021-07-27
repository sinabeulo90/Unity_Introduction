using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerEffect : MonoBehaviour
{
    private Color originalColor;
    private Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        originalColor = renderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        float level = Mathf.Abs(Mathf.Sin(Time.time * 20));
        renderer.material.color = originalColor * level;
    }
}
