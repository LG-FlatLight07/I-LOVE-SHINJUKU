using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClick : MonoBehaviour
{
    // インスペクタビューから設定するシーン名
    public string sceneName;

    public void OnClickStartButton()
    {
        SceneManager.LoadScene(sceneName);
    }

}
