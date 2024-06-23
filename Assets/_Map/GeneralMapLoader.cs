﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneralMapLoader : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            SceneManager.LoadScene("1_VSMobMatching"); 
        }
        
        if (Input.GetKeyDown("2"))
        {
            SceneManager.LoadScene("3_VSMobResult");
        }

        if (Input.GetKeyDown("3"))
        {
            SceneManager.LoadScene("4_VSKagami1Matching");
        }

        if (Input.GetKeyDown("4"))
        {
            SceneManager.LoadScene("6_VSKagami1Result");
        }

        if (Input.GetKeyDown("5"))
        {
            SceneManager.LoadScene("7_VSKagami2Matching");
        }

        if (Input.GetKeyDown("6"))
        {
            SceneManager.LoadScene("9_VSKagami2Result");
        }
    }
}
