using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UFE3D;

public class StartInGame : MonoBehaviour
{
    //変数宣言
    [SerializeField]
    private UFE3D.CharacterInfo p1CharAsset;
    [SerializeField]
    private UFE3D.CharacterInfo p2CharAsset;
    [SerializeField]
    private StageOptions stagePrefab;
    [SerializeField]
    private float gameFadeDuration;

    private void Awake()
    {
        UFE.gameMode = GameMode.VersusMode; // or GameMode.TrainingMode if you want Training.
        UFE.config.player1Character = p1CharAsset; // or whatever variable you have the Character Asset file set 
        UFE.config.player2Character = p2CharAsset; // or whatever variable you have the Character Asset file set 
        UFE.config.selectedStage = stagePrefab; // or whatever variable you have the Stage Prefab file set
        UFE.SetCPU(1, false); // Set to true for AI on P1
        UFE.SetCPU(2, false); // Set to true for AI on P2
        UFE.StartGame(gameFadeDuration);
    }
}
