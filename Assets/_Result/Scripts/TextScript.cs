//Textのフェードイン、フェードアウト

using System.Collections;
using System.Collections.Generic;
using TMPro; //TextMeshProを扱う際に必要
using UnityEngine;

public class TextScript : MonoBehaviour
{
    
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
        // コンポ取得
        TextMeshProUGUI textMeshPro = GetComponent<TextMeshProUGUI>();
        // 現在のカラーを取得
        Color currentColor = textMeshPro.color;
        while (true)
        {
            for (int i = 0; i < 255; i++)
            {
                // 新しいアルファ値を設定
                currentColor.a += 0.01f;

                // 設定した新しいカラーを適用
                textMeshPro.color = currentColor;
                yield return new WaitForSeconds(0.01f);
            }
        }
    }
    IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(2f);
        //2秒待ってから何か処理をする
        // コンポ取得
        TextMeshProUGUI textMeshPro = GetComponent<TextMeshProUGUI>();
        // 現在のカラーを取得
        Color currentColor = textMeshPro.color;
        while (true)
        {
            for (int i = 0; i < 255; i++)
            {
                // 新しいアルファ値を設定
                currentColor.a -= 0.01f;

                // 設定した新しいカラーを適用
                textMeshPro.color = currentColor;
                yield return new WaitForSeconds(0.01f);
            }
        }
      
    }

}
