using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//マッチングシステム 
public class ResultFadain : MonoBehaviour
{
    float Speed = 0.01f;
    float red, green, blue, alfa;

    public bool Out = false;
    public bool In = false;

    public SpriteRenderer fadeImage;

    [SerializeField] //開始時ディレイ
    private float StartDelayTime = 3;
    [SerializeField] //終了時ディレイ
    private float EndDelayTime = 6;

    // インスペクタビューから設定するシーン名
    public string sceneName;

    void Start()
    {
        //スプライトレンダラー
        fadeImage = GetComponent<SpriteRenderer>();
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;

        StartCoroutine(StartDelay());

    }

    void Update()
    {

        if (In)
        {
            FadeIn();
        }

        if (Out)
        {
            FadeOut();
        }
    }


    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(StartDelayTime);
        In = true;
        //StartCoroutine(EndDelay());
    }

    IEnumerator EndDelay()
    {
        yield return new WaitForSeconds(EndDelayTime);
        Out = true;

        //マップを開く
        Invoke("ChangeScene", 3f);
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
            SceneManager.LoadScene(sceneName);
        }
    }

    void Alpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }
}
