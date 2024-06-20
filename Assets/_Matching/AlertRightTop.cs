using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//右上の通知
public class AlertRightTop : MonoBehaviour
{
    //アラートイメージ
    public Image alertImage;

    private void Start()
    {
        alertImage.enabled = false;
    }

    private void Update()
    {
        //3番キー
        if (Input.GetKeyDown("3"))
        {
            Debug.Log("3");
            ActivateAlert();
        }
    }
    //通知有効化
    public void ActivateAlert()
    {
        alertImage.enabled = true;
    }
}
