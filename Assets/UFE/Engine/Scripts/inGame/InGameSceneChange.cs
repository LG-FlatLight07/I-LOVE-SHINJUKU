using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameSceneChange : MonoBehaviour
{
    //切り替え先のマップ
    [SerializeField]
    private string NextScene; 

    /// <summary>
    /// シーンの切り替え
    /// </summary>
    public void ChangeScene()
    {
        if (NextScene == null) return;
        SceneManager.LoadScene(NextScene);
    }
}
