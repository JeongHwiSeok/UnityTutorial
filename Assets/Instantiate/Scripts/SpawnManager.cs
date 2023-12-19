using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] List<Unit> listUnits;

    [SerializeField] Factory factory;

    public Vector3 direction;

    float timer = 0;

    private void Start()
    {
        direction.x = 0;
        // Instantiate : 게임 오브젝트를 생성하는 함수
        #region for문을 이용한 몬스터 스폰
        //for(int i = 0; i < spawnMax; i++)
        //{
        //    // 1. 게임 오브젝트를 생성
        //    GameObject monster = Instantiate(unit, createPosition);

        //    // 2. 생성된 게임 오브젝트의 위치를 설정
        //    // monster.transform.position += direction;
        //    monster.transform.position = new Vector3(i * 5, 0, createPosition.position.z);

        //    Debug.Log("World Position : " + monster.transform.position);
        //    Debug.Log("Local Position : " + monster.transform.localPosition);

        //    direction.x += 5;      
        //}
        #endregion

        StartCoroutine(CreateRoutine());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(LogRoutine());
        }
    }

    public IEnumerator CreateRoutine()
    {
        while(true)
        {
            // Random.Range(0, n) : 0 ~ n-1 까지의 값을 반환
            factory.CreateUnit(listUnits[Random.Range(0, listUnits.Count)]);

            // new WaitForSeconds() : 특정한 시간동안 코루틴을 대기
            yield return new WaitForSeconds(5f);
        }
    }

    public IEnumerator LogRoutine()
    {
        yield return new WaitForSeconds(1f);

        Debug.Log("Attack");
    }
}
