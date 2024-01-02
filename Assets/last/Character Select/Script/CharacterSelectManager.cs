using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectManager : MonoBehaviour
{
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

        characterList[DataManager.instance.SelectCount].SetActive(true);
        characterList[DataManager.instance.SelectCount].transform.position = new Vector3(0, 0, 0);
        characterList[DataManager.instance.SelectCount].transform.rotation = new Quaternion(0, 0, 0, 0);
    }
    
    public void OnLeftButton()
    {
        DataManager.instance.SelectCount--;

        if(DataManager.instance.SelectCount < 0)
        {
            DataManager.instance.SelectCount = characterList.Count - 1;
        }

        Show();
        DataManager.instance.Save();
    }

    public void OnRightButton()
    {
        DataManager.instance.SelectCount++;

        if(DataManager.instance.SelectCount >= characterList.Count)
        {
            DataManager.instance.SelectCount = 0;
        }

        Show();
        DataManager.instance.Save();
    }
}
