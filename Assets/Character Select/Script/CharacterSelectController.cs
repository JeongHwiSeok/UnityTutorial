using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectController : MonoBehaviour
{
    [SerializeField] GameObject[] gameObjects;
    public int i = 0;

    private void Awake()
    {
        gameObjects[0].active = false;
        gameObjects[1].active = false;
        gameObjects[2].active = false;

        gameObjects[i].active = true;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            LeftButton();
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            RightButton();
        }
    }

    public void RightButton()
    {
        gameObjects[i].active = false;
        i--;
        if(i < 0)
        {
            i = 2;
        }
        gameObjects[i].active = true;
        gameObjects[i].transform.position = new Vector3(0, 0, 0);
    }

    public void LeftButton()
    {
        gameObjects[i].active = false;
        i++;
        if (i > 2)
        {
            i = 0;
        }
        gameObjects[i].active = true;
        gameObjects[i].transform.position = new Vector3(0, 0, 0);
    }
}
