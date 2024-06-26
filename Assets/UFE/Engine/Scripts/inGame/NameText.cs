using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameText : MonoBehaviour
{
    [SerializeField]
    private GameObject playerName1;
    [SerializeField]
    private GameObject playerName2;
    private bool nameSetActive;

    private void Start()
    {
        nameSetActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            if(nameSetActive == true)
            {
                nameSetActive = false;
            }
            else
            {
                nameSetActive = true;
            }

            playerName1.SetActive(nameSetActive);
            playerName2.SetActive(nameSetActive);
        }
    }
}
