using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    [SerializeField] GameObject target;

    [SerializeField] float speed = 5f;

    private void Awake()
    {
        target = GameObject.Find("Player");
    }

    protected virtual void Update()
    {
        // LookAt() : Ư���� ����� �ٶ󺸴� �Լ�
        transform.LookAt(target.transform);
        TargetTracing();
    }

    protected virtual void TargetTracing()
    {
        // 1. ���⺤�� ����
        Vector3 direction = target.transform.position - transform.position;

        direction.y = 0;

        // 2. ������ ����ȭ
        direction.Normalize();

        // 3. �̵�����
        transform.position += direction * speed * Time.deltaTime;
    }

    // OnTriggerEnter() : Trigger �浹�� �Ǿ��� �� �̺�Ʈ�� ȣ���ϴ� �Լ�
    private void OnTriggerEnter(Collider other)
    {
        speed = 0f;
        Debug.Log("OnTriggerEnter");
    }

    // OnTriggerStay() : Trigger �浹���϶� �̺�Ʈ�� ȣ���ϴ� �Լ�
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }

    // OnTriggerExit() : Trigger �浹�� ������ �� �̺�Ʈ�� ȣ���ϴ� �Լ�
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
    }
    public abstract void Move();
}
