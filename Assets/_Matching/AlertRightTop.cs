using System;
using UnityEngine;
using UnityEngine.UI;

//右上の通知
public class AlertRightTop : MonoBehaviour
{
    //アラートイメージ
    public SpriteRenderer alertSprite;

    private Animator anim = null;

    private void Start()
    {
        anim = GetComponent<Animator>();

        alertSprite.enabled = false;
    }

    private void Update()
    {
        //挑戦状通知
        if (Input.GetKeyDown("q"))
        {
            //anim.SetTrigger("Activate");
            alertSprite.enabled = true;
        }
    }
}
