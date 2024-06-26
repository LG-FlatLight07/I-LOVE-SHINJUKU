using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick : MonoBehaviour
{
    [SerializeField]
    private Image kieuseroButton;

    private GameObject sphereObject;
    ResultFadain resultfadain;

    public void OnClickStartButton()
    {
        sphereObject = GameObject.Find("Black");
        resultfadain = sphereObject.GetComponent<ResultFadain>();
        resultfadain.Out = true;
        kieuseroButton.enabled = false;
    }

}
