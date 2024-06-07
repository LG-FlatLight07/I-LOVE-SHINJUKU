//Textのフェードイン、フェードアウト

using System.Collections;
using System.Collections.Generic;
using TMPro; //TextMeshProを扱う際に必要
using UnityEngine;

public class TextScript : MonoBehaviour
{
    [SerializeField]
    private float X;
    [SerializeField]
    private float Y;
    [SerializeField]
    private float num;
    private bool OnBlinking = false;
    void Start()
    {
        // コンポ取得
        TextMeshProUGUI textMeshPro = GetComponent<TextMeshProUGUI>();
        // 現在のカラーを取得
        Color currentColor = textMeshPro.color;

        // 新しいアルファ値を設定
        currentColor.a = 0.0f; 

        // 設定した新しいカラーを適用
        textMeshPro.color = currentColor;

        StartCoroutine("FadeIn");
        StartCoroutine("FadeOut");
    }

    IEnumerator FadeIn()
    {
        yield return new WaitForSeconds(X);
        //2秒待ってから何か処理をする
        bool OnFadeIn = true;
        // コンポ取得
        TextMeshProUGUI textMeshPro = GetComponent<TextMeshProUGUI>();
        // 現在のカラーを取得
        Color currentColor = textMeshPro.color;
        while (OnFadeIn==true)
        {
            for (int i = 0; i < 255; i++)
            {
                // 新しいアルファ値を設定
                currentColor.a += num;

                // 設定した新しいカラーを適用
                textMeshPro.color = currentColor;
               
                yield return new WaitForSeconds(0.01f);
            }
            if (X == 6)
            {
                gameObject.SetActive(false);  
            }
            OnFadeIn = false;
        }
    }
    IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(Y);
        //2秒待ってから何か処理をする

        bool OnFadeOut=true;

        // コンポ取得
        TextMeshProUGUI textMeshPro = GetComponent<TextMeshProUGUI>();
        // 現在のカラーを取得
        Color currentColor = textMeshPro.color;
        while (OnFadeOut==true)
        {
            for (int i = 0; i < 255; i++)
            {
                // 新しいアルファ値を設定
                currentColor.a -= 0.01f;

                // 設定した新しいカラーを適用
                textMeshPro.color = currentColor;
                yield return new WaitForSeconds(0.01f);
            }
            Destroy(gameObject);
            OnFadeOut = false;
        }
    }
}
