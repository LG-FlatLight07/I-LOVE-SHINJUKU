//text移動

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextMove : MonoBehaviour
{
    float w = Screen.width;
    float h = Screen.height;
    public TMP_Text m_tmpText;          //text
    private float X;                    //X座標入力
    private float Y;                    //Y座標入力
    [SerializeField]
    private int num;                    //どちらに進むか入力（+右-左）
    bool OnMove = true;
    void Start()
    {
        StartCoroutine("FadeIn");
        X = w / 2;
        if(num>0)
        {
            transform.position = new(w / -6, -h/8, 0);
        }
        else
        {
            transform.position = new(w / 6, (-3*h) / 8, 0);
        }
        w /= 6;
        Y = transform.position.y;
        Debug.Log(w);
        Debug.Log(h);
    }
   
    IEnumerator FadeIn()
    {
        //text座標取得
        var x = m_tmpText.GetEdgeLeft();
        var y = m_tmpText.GetEdgeBottom();

        while (OnMove==true)
        {
            //右に進む
           if(num==3)
            {
                for (int i = 0; i < 1000; i++)
                {
                    x += w/60;                               //X座標にnum加算
                    transform.position = new(x, Y, 0);      //座標をずらす
                                                            
                    //目的地についたらbreakで終了
                    if (x >= X)
                    {
                        OnMove = false;
                        break;
                    }

                    yield return new WaitForSeconds(0.01f);
                }
            }
           //左に進む
            else
            {
                for (int i = 0; i < 1000; i++)
                {
                    x -= w / 60;                                   //X座標にnum加算
                    transform.position = new(x, Y, 0);           //座標をずらす

                    //目的地についたらbreakで終了
                    if (x <= X)
                    {
                        OnMove = false;
                        break;
                    }

                    yield return new WaitForSeconds(0.01f);
                }
            }
            
        }
    }
}
