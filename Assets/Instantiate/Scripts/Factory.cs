using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    [SerializeField] Transform spawnPosition;

    public GameObject CreateUnit(Unit unit)
    {
        return Instantiate(unit.gameObject, spawnPosition);
    }
}
