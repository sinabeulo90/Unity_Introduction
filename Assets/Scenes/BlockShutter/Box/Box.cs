using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public GameObject explosionPrefab;

    private bool damaged;
    private float killTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!damaged)
        {
            return;
        }
        killTimer -= Time.deltaTime;
        if (killTimer <= 0.0)
        {
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    void ApplyDamage()
    {
        if (!damaged)
        {
            damaged = true;
            killTimer = 0.4F;
            GetComponent<Rigidbody>().AddForce(Vector3.up * 15.0F, ForceMode.Impulse);
        }
    }
}
