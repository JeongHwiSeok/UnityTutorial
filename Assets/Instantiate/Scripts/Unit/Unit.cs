using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public enum State
{
    Move,
    Attack,
    Die,
    None
}

[RequireComponent(typeof(HPBar))]
public abstract class Unit : MonoBehaviour
{
    [SerializeField] GameObject target;

    [SerializeField] State state;
    
    [SerializeField] Vector3 targetDirection;
    [SerializeField] Animator animator;

    [SerializeField] float speed = 5f;

    [SerializeField] protected float health;
    [SerializeField] protected float maxHealth;

    [SerializeField] HPBar healthBar;

    [SerializeField] Sound sound = new Sound();

    private void Awake()
    {
        target = GameObject.Find("Player");

        healthBar = GetComponent<HPBar>();
        animator = GetComponent<Animator>();
        state = State.Move;
    }

    protected virtual void Update()
    {
        switch(state)
        {
            case State.Move: Move();
                break;
            case State.Attack: Attack();
                break;
            case State.Die: Die();
                break;
            case State.None: 
                break;
        }
    }

    public void OnHit(float damage)
    {
        if (health <= 0) return;

        health -= damage;
        healthBar.UpdateHP(health, maxHealth);

        if (health <= 0)
        {
            state = State.Die;
        }
    }

    public virtual void Release()
    {
        Destroy(gameObject);
    }

    public virtual void Move()
    {
        animator.SetBool("Attack", false);

        // 1. 방향벡터 산출
        Vector3 direction = target.transform.position - transform.position;
        targetDirection = target.transform.position;

        direction.y = 0;
        targetDirection.y = 0;

        // 2. 벡터의 정규화
        direction.Normalize();

        // LookAt() : 특정한 대상을 바라보는 함수
        transform.LookAt(targetDirection);

        // 3. 이동시작
        transform.position += direction * speed * Time.deltaTime;
    }

    public virtual void Attack()
    {
        animator.SetBool("Attack", true);   
    }

    public void AttackSound()
    {
        SoundManager.instance.Sound(sound.audioClips[0]);
        Debug.Log(sound.audioClips[0]);
    }

    public virtual void Die()
    {
        animator.Play("Die");
        SoundManager.instance.Sound(sound.audioClips[1]);

        state = State.None;
    }

    // OnTriggerEnter() : Trigger 충돌이 되었을 때 이벤트를 호출하는 함수
    private void OnTriggerEnter(Collider other)
    {
        state = State.Attack;
    }

    // OnTriggerStay() : Trigger 충돌중일때 이벤트를 호출하는 함수
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }

    // OnTriggerExit() : Trigger 충돌이 끝났을 때 이벤트를 호출하는 함수
    private void OnTriggerExit(Collider other)
    {
        state = State.Move;
    }
}