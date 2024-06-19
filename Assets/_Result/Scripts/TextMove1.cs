//text移動

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextMove1 : MonoBehaviour
{
    public TMP_Text m_tmpText;          //text
    [SerializeField]
    private float X;                    //X座標入力
    [SerializeField]
    private float Y;                    //Y座標入力
    [SerializeField]
    private int num;                    //どちらに進むか入力（+右-左）
    bool OnMove = true;
    float x;
    float y;
    void Start()
    {
        Debug.Log(X);
        Debug.Log(Y);
        transform.position = new(x, -51, 0);
       
    }
   
    IEnumerator FadeIn()
    {

         while (OnMove==true)
         {
             //右に進む
            if(num==3)
             {
                 for (int i = 0; i < 1000; i++)
                 {
                //     x += X+1;                               //X座標にnum加算
                   //  transform.position = new(x, Y, 0);      //座標をずらす

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
                   //  x -= X +1;                                   //X座標にnum加算
                  //   transform.position = new(x, Y, 0);           //座標をずらす

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
