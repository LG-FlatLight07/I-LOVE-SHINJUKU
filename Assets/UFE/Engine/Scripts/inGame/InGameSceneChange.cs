using System.Collections;
using System.Collections.Generic;
//using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UFE3D;

public class InGameSceneChange : VersusModeAfterBattleScreen
{
    #region public override methods

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
    public override void OnShow()
    {
        base.OnShow();
    }

    public override void DoFixedUpdate(
       IDictionary<InputReferences, InputEvents> player1PreviousInputs,
       IDictionary<InputReferences, InputEvents> player1CurrentInputs,
       IDictionary<InputReferences, InputEvents> player2PreviousInputs,
       IDictionary<InputReferences, InputEvents> player2CurrentInputs
   )
    { }
    #endregion
}
