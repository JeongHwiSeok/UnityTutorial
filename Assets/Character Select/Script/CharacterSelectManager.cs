using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectManager : MonoBehaviour
{
    [SerializeField] int selectCount = 0;
    [SerializeField] List<GameObject> characterList;

    // Start is called before the first frame update
    void Start()
    {
        characterList.Capacity = 5;

        Show();
    }

    private void Show()
    {
        for(int i = 0; i < characterList.Count; i++)
        {
            characterList[i].SetActive(false);
        }

        characterList[selectCount].SetActive(true);
    }
}
