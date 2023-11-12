using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThunderManager : MonoBehaviour
{
    public Image brightnessImage;
    public float thunderTimer;
    private Color newColor;
    private float brightColor;

    private float timer;
    bool isThunder; 

    // Start is called before the first frame update
    void Start()
    {
        isThunder = true;
        newColor = brightnessImage.color;
        newColor.a = 0;
        brightnessImage.color = newColor;
        timer = 1;
    }

    // Update is called once per frame
    void Update()
    {
        thunderTimer -= Time.deltaTime;


        if (isThunder)
        {
            timer -= Time.deltaTime * 2;
            brightColor = timer;
            newColor.a = brightColor;
            brightnessImage.color = newColor;

            if (brightColor <= 0)
            {
                thunderTimer = Random.Range(9, 11);
                isThunder = false;
            }

            return;
        }

        if(thunderTimer <= 0)
        {
            isThunder = true;

            timer = 1;
            brightColor = timer;
        }



    }
}
