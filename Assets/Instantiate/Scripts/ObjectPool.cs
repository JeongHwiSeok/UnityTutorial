using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool instance;

    [SerializeField] Unit unit;

    [SerializeField] int createCount;

    [SerializeField] List<GameObject> unitList;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        unitList.Capacity = 20;

        CreatePool();
    }

    private void CreatePool()
    {
        for (int i = 0; i < createCount; i++)
        {
            GameObject obj = Factory.instance.CreateUnit(unit);

            obj.SetActive(false);

            unitList.Add(obj);
        }
    }

    public GameObject GetObject(int k)
    {
        if(CheckObject())
        {
            GameObject obj = Factory.instance.CreateUnit(unit);

            obj.SetActive(false);

            unitList.Add(obj);

            return obj;
        }
        else if(unitList[k].activeSelf == false)
        {
            return unitList[k];
        }
        else
        {
            k++;
            return GetObject(k);
        }
    }

    private bool CheckObject()
    {
        for(int i = 0; i <unitList.Count; i++)
        {
            if(unitList[i].activeSelf == false)
            {
                return false;
            }
        }
        return true;
    }
}
