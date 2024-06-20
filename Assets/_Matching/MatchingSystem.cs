using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//マッチングシステム 
public class MatchingSystem : MonoBehaviour
{
    float Speed = 0.01f;
    float red, green, blue, alfa;

    public bool Out = false;
    public bool In = false;

    public Image fadeImage;

    void Start()
    {
        fadeImage = GetComponent<Image>();
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;
    }

    void Update()
    {
        //フェードアウト
        if (Input.GetKey("1"))
        {
            Out = true;
            FadeOut();
            Debug.Log("1");
        }

        //フェードイン
        if (Input.GetKey("2"))
        {
            In = true;
            FadeIn();
            Debug.Log("2");
        }

        //3番キー
        if (Input.GetKeyDown("3"))
        {
            Debug.Log("3");
        }

        //4番キー
        if (Input.GetKeyDown("4"))
        {
            Debug.Log("4");
        }
    }

    void FadeIn()
    {
        alfa -= Speed;
        Alpha();
        if (alfa <= 0)
        {
            In = false;
        }
    }

    void FadeOut()
    {
        alfa += Speed;
        Alpha();
        if (alfa >= 1)
        {
            Out = false;
        }
    }

    void Alpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }
}
