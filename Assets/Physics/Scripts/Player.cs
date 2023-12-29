using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] UnityEvent playerEvent;

    private void OnCollisionEnter(Collision collision)
    {
        playerEvent.Invoke();
    }
}
