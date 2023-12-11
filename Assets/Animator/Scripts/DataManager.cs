using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public float[] times;

    public void Start()
    {
        for(int i = 0; i < times.Length; i++)
        {
            Debug.Log(times[i]);
        }
    }
}
