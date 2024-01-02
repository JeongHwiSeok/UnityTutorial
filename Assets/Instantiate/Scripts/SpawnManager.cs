using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{ 
    public Vector3 direction;

    // float timer = 0;

    private void Start()
    {
        direction.x = 0;
        // Instantiate : ���� ������Ʈ�� �����ϴ� �Լ�
        #region for���� �̿��� ���� ����
        //for(int i = 0; i < spawnMax; i++)
        //{
        //    // 1. ���� ������Ʈ�� ����
        //    GameObject monster = Instantiate(unit, createPosition);

        //    // 2. ������ ���� ������Ʈ�� ��ġ�� ����
        //    // monster.transform.position += direction;
        //    monster.transform.position = new Vector3(i * 5, 0, createPosition.position.z);

        //    Debug.Log("World Position : " + monster.transform.position);
        //    Debug.Log("Local Position : " + monster.transform.localPosition);

        //    direction.x += 5;      
        //}
        #endregion

        StartCoroutine(CreateRoutine());
    }

    public IEnumerator CreateRoutine()
    {
        while(true)
        {
            // Random.Range(0, n) : 0 ~ n-1 ������ ���� ��ȯ
            ObjectPool.instance.GetObject(0).SetActive(true);

            // new WaitForSeconds() : Ư���� �ð����� �ڷ�ƾ�� ���
            yield return new WaitForSeconds(5f);
        }
    }
}
