using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UFE3D;

public class StartInGame : MonoBehaviour
{
    //変数宣言
    //キャラの取得
    [SerializeField]
    UFE3D.CharacterInfo playerCharaInfo1;
    [SerializeField]
    UFE3D.CharacterInfo playerCharaInfo2;

    void Start()
    {
        // プレイヤー情報の設定
        if (playerCharaInfo1 != null)
        {
            UFE.SetPlayer1(playerCharaInfo1);
        }
        if (playerCharaInfo2 != null)
        {
            UFE.SetPlayer2(playerCharaInfo2);
        }
        

        // PVPを開始
        UFE.StartPlayerVersusPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
