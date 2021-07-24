using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltRig : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation =
            Quaternion.AngleAxis(Input.GetAxis("Horizontal") * 10.0F, Vector3.forward) *
            Quaternion.AngleAxis(Input.GetAxis("Vertical") * -10.0F, Vector3.right);
    }
}
