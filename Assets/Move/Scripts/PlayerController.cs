using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 direction;

    public float speed = 1f;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        // Input.GetAxis() : 특정한 key를 누를 때 -1 ~ 1 사이의 값을 반환하는 함수
        direction.x = Input.GetAxis("Vertical");
        direction.z = Input.GetAxis("Horizontal");
        
        direction.x *= -1;

        direction.Normalize();

        // Time.deltaTime : 이전 프레임이 완료되는 데까지 걸린 시간을 의미
        transform.position += direction * speed * Time.deltaTime;
    }
}