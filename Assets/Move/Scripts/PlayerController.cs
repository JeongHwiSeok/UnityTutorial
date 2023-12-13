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
        // Input.GetAxis() : Ư���� key�� ���� �� -1 ~ 1 ������ ���� ��ȯ�ϴ� �Լ�
        direction.x = Input.GetAxis("Vertical");
        direction.z = Input.GetAxis("Horizontal");
        
        direction.x *= -1;

        direction.Normalize();

        // Time.deltaTime : ���� �������� �Ϸ�Ǵ� ������ �ɸ� �ð��� �ǹ�
        transform.position += direction * speed * Time.deltaTime;
    }
}