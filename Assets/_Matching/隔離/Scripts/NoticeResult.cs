using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// リザルトの通知を召喚するスクリプト
public class NoticeResult : MonoBehaviour
{
    //通知イメージ
    public Image NoticeImage;
    
    private void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            Debug.Log("z");
        }
    }
}
