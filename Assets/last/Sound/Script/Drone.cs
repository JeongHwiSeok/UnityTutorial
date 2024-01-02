using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{
    public float speed = 55;
    public Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = transform.position;

        // InvokeRepeating() : Ư���� �Լ��� Ư���� �ð��� ���� �Ŀ� Ư���� �ð����� �ݺ������� ȣ���ϴ� �Լ�

        // ù ��° �Ű����� : ������ �Լ��� �̸�

        // �� ��° �Ű����� : Ư���� �ð��� ���� �� ������ �ð�
        
        // �� ��° �Ű����� : Ư���� �ð����� �ݺ������� �Լ��� ȣ���ϴ� �ð�

        InvokeRepeating(nameof(NewPosition), 5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate
        (
            Vector3.forward * speed * Time.deltaTime
        );
    }

    private void NewPosition()
    {
        transform.position = direction;
        transform.Find("Canvas").gameObject.SetActive(false);
    }
}
