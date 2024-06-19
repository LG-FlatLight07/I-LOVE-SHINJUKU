using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MatchingSystem : MonoBehaviour
{
    private Animator anim = null;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        //開く
        if (Input.GetKeyDown("1"))
        {
            OpenRank();
        }

        //閉じる
        if (Input.GetKeyDown("2"))
        {
            CloseRank();
        }
    }

    void OpenRank()
    {
        anim.SetTrigger("Open");
    }

    void CloseRank()
    {
        anim.SetTrigger("Close");
    }
}
