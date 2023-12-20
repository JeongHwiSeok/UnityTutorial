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
        // LookAt() : 특정한 대상을 바라보는 함수
        transform.LookAt(target.transform);
        TargetTracing();
    }

    protected virtual void TargetTracing()
    {
        // 1. 방향벡터 산출
        Vector3 direction = target.transform.position - transform.position;

        direction.y = 0;

        // 2. 벡터의 정규화
        direction.Normalize();

        // 3. 이동시작
        transform.position += direction * speed * Time.deltaTime;
    }

    // OnTriggerEnter() : Trigger 충돌이 되었을 때 이벤트를 호출하는 함수
    private void OnTriggerEnter(Collider other)
    {
        speed = 0f;
        Debug.Log("OnTriggerEnter");
    }

    // OnTriggerStay() : Trigger 충돌중일때 이벤트를 호출하는 함수
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }

    // OnTriggerExit() : Trigger 충돌이 끝났을 때 이벤트를 호출하는 함수
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
    }
    public abstract void Move();
}
