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
    [SerializeField]
    private float A;

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
            for (int i = 0; i < A; i++)
            {
                // 新しいアルファ値を設定
                currentColor.a += num;

                // 設定した新しいカラーを適用
                textMeshPro.color = currentColor;
               
                yield return new WaitForSeconds(0.0f);
            }
            if (X == 6)
            {
                yield return StartCoroutine("OnBlinking");
            }
            else
            {
                yield return StartCoroutine("FadeOut");
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
            for (int i = 0; i < 60; i++)
            {
                // 新しいアルファ値を設定
                currentColor.a -= 0.02f;

                // 設定した新しいカラーを適用
                textMeshPro.color = currentColor;
                yield return new WaitForSeconds(0.0f);
            }
            Destroy(gameObject);
            OnFadeOut = false;
        }
    }
    IEnumerator OnBlinking()
    {
        yield return new WaitForSeconds(0.0f);
        //2秒待ってから何か処理をする
        // コンポ取得
        TextMeshProUGUI textMeshPro = GetComponent<TextMeshProUGUI>();
        // 現在のカラーを取得
        Color currentColor = textMeshPro.color;
        // 新しいアルファ値を設定
        currentColor.a = 0.0f;

        // 設定した新しいカラーを適用
        textMeshPro.color = currentColor;
        yield return StartCoroutine("OffBlinking");
    }
    IEnumerator OffBlinking()
    {
        yield return new WaitForSeconds(0.1f);
        // コンポ取得
        TextMeshProUGUI textMeshPro = GetComponent<TextMeshProUGUI>();
        // 現在のカラーを取得
        Color currentColor = textMeshPro.color;
        // 新しいアルファ値を設定
        currentColor.a = 1.0f;

        // 設定した新しいカラーを適用
        textMeshPro.color = currentColor;
        Debug.Log("デバッグログのメッセージ");
    }
}
