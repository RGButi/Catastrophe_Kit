using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingImage : MonoBehaviour
{
    [SerializeField] private RawImage Img;
    [SerializeField] private float x;

    // Update is called once per frame
    void Update()
    {
        Img.uvRect = new Rect(Img.uvRect.position + new Vector2(x, 0) * Time.deltaTime, Img.uvRect.size);
    }
}
