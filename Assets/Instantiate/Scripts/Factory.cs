using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public static Factory instance;

    [SerializeField] Transform spawnPosition;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public GameObject CreateUnit(Unit unit)
    {
        return Instantiate(unit.gameObject, spawnPosition);
    }
}
