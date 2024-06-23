using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UFE3D;

public class DebugPlayerMove : MonoBehaviour
{

    void OnMove(MoveInfo moveInfo, ControlsScript player)
    {
        Debug.Log(moveInfo);
    }
}
