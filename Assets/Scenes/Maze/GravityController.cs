using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics.gravity =
            Quaternion.AngleAxis(Input.GetAxis("Horizontal") * 60.0F, Vector3.forward) *
            Quaternion.AngleAxis(Input.GetAxis("Vertical") * -60.0F, Vector3.right) *
            (Vector3.up * -20.0F);
    }
}
