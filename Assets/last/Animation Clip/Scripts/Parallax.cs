using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parallax : MonoBehaviour
{

    [SerializeField] Rect rect;
    [SerializeField] RawImage rawimage;
    [SerializeField] float speed = 0.25f;

    // Update is called once per frame
    void Update()
    {
        rect = rawimage.uvRect;
        rect.x += Time.deltaTime * speed;

        rawimage.uvRect = rect;
    }
}
