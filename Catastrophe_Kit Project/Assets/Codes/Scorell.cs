using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorel : MonoBehaviour
{
    [SerializeField] private RawImage _img;
    [SerializeField] private float x, y;

    void Update()
    {
        // You need to use Time.deltaTime (note the capital 'D') instead of Time.DeltaTime
        _img.uvRect = new Rect(_img.uvRect.position + new Vector2(x, y) * Time.deltaTime, _img.uvRect.size);
    }
}