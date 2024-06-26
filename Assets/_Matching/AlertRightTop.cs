﻿using System;
using UnityEngine;
using UnityEngine.UI;

//右上の通知
public class AlertRightTop : MonoBehaviour
{
    //アラートイメージ
    public SpriteRenderer alertSprite;
    public Image Image1;
    public Image Image2;

    private Animator anim = null;

    private void Start()
    {
        anim = GetComponent<Animator>();

        alertSprite.enabled = false;
        if (!Image1) return;
        Image1.enabled = false;
        if (!Image2) return;
        Image2.enabled = false;
    }

    private void Update()
    {
        //挑戦状通知
        if (Input.GetKeyDown("q"))
        {
            //anim.SetTrigger("Activate");
            alertSprite.enabled = true;
            if (!Image1) return;
            Image1.enabled = true;
            if (!Image2) return;
            Image2.enabled = true;
        }
    }
}
