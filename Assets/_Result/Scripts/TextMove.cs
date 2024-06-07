//text移動

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextMove : MonoBehaviour
{
    public TMP_Text m_tmpText;          //text
    [SerializeField]
    private float X;                    //X座標入力
    [SerializeField]
    private float Y;                    //Y座標入力
    [SerializeField]
    private int num;                    //どちらに進むか入力（+右-左）
    bool OnMove = true;
    void Start()
    {
        StartCoroutine("FadeIn");
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
                    x += num;                               //X座標にnum加算
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
                    x += num;                                   //X座標にnum加算
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
