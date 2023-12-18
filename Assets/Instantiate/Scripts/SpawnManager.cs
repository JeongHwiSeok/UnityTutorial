using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject unit;
    [SerializeField] Transform createPosition;

    [Tooltip("몬스터를 생성하는 변수")]
    [SerializeField] int spawnMax = 5;
    public Vector3 direction;

    private void Start()
    {
        direction.x = 0;
        // Instantiate : 게임 오브젝트를 생성하는 함수
        for(int i = 0; i < spawnMax; i++)
        {
            // 1. 게임 오브젝트를 생성
            GameObject monster = Instantiate(unit, createPosition);

            // 2. 생성된 게임 오브젝트의 위치를 설정
            // monster.transform.position += direction;
            monster.transform.position = new Vector3(i * 5, 0, createPosition.position.z);

            Debug.Log("World Position : " + monster.transform.position);
            Debug.Log("Local Position : " + monster.transform.localPosition);

            direction.x += 5;      
        }
    }
}
