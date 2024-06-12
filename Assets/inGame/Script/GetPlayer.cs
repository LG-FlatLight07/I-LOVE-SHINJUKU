using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UFE3D;

public class GetPlayer : MonoBehaviour
{
    [SerializeField]
    private UFE3D.MoveInfo player1MoveInfo;
    [SerializeField]
    private UFE3D.MoveInfo player2MoveInfo;
    private UFE3D.CharacterInfo player1;
    private UFE3D.CharacterInfo player2;

    // Start is called before the first frame update
    void Start()
    {
        player1 = null;
        player2 = null;
    }

    // Update is called once per frame
    void Update()
    {
        if(InputManager.GetKey(Key.C))
        {
            if(player1 == null)
            {
                player1 = UFE.GetPlayer1();
            }
            if(player2 == null)
            {
                player2 = UFE.GetPlayer2();
            }

            Debug.Log(player1.moves);
            Debug.Log(player2.moves);

            player1.moves.attackMoves = player1MoveInfo;
        }
    }
}
