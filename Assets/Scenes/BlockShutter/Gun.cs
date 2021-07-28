using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float initialVelocity;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            Vector3 screenPoint = Input.mousePosition;  // 화면 좌표계
            screenPoint.z = 10.0F;                      // 화면 좌표계에서 전방으로 10.0F만큼 이동
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(screenPoint);   // 화면 좌표계를 월드 좌표계로 변환

            // transform.position: 월드 좌표계
            // 월드 좌표계끼리 빼서 상대 벡터를 계산한 뒤, 단위 벡터를 방향 벡터로 설정한다.
            Vector3 direction = (worldPoint - transform.position).normalized;
            bullet.GetComponent<Rigidbody>().velocity = direction * initialVelocity;
        }
    }
}
