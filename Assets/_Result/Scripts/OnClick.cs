using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OnClick : MonoBehaviour
{
    private GameObject sphereObject;
    ResultFadain resultfadain;

    public void OnClickStartButton()
    {
        sphereObject = GameObject.Find("Black");
        resultfadain = sphereObject.GetComponent<ResultFadain>();
        resultfadain.Out = true;
    }

}
