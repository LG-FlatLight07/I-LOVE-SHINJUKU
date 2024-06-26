using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//マッチングシステム 
public class MatchingSystem : MonoBehaviour
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
    [SerializeField] //シーンのテキスト
    private String SceneString;
    
    void Start()
    {
        //スプライトレンダラー
        fadeImage = GetComponent<SpriteRenderer>();
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;
        
    }

    void Update()
    {
        //フェードイン
        if (Input.GetKey("e"))
        {
            StartCoroutine(StartDelay());
        }

        //マップオープン
        if(Input.GetKey("r"))
        {
            //マップを開く
            Invoke("ChangeScene", 0.2f);
        }

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
        StartCoroutine(EndDelay());
    }
    
    IEnumerator EndDelay()
    {
        yield return new WaitForSeconds(EndDelayTime);
        Out = true;
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(SceneString);
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
