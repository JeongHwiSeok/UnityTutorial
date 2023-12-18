using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject unit;
    [SerializeField] Transform createPosition;

    [Tooltip("���͸� �����ϴ� ����")]
    [SerializeField] int spawnMax = 5;
    public Vector3 direction;

    private void Start()
    {
        direction.x = 0;
        // Instantiate : ���� ������Ʈ�� �����ϴ� �Լ�
        for(int i = 0; i < spawnMax; i++)
        {
            // 1. ���� ������Ʈ�� ����
            GameObject monster = Instantiate(unit, createPosition);

            // 2. ������ ���� ������Ʈ�� ��ġ�� ����
            // monster.transform.position += direction;
            monster.transform.position = new Vector3(i * 5, 0, createPosition.position.z);

            Debug.Log("World Position : " + monster.transform.position);
            Debug.Log("Local Position : " + monster.transform.localPosition);

            direction.x += 5;      
        }
    }
}
