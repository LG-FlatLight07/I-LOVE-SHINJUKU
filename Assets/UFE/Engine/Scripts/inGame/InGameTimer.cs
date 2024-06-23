using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameTimer : MonoBehaviour
{

    /*変数宣言*/
    /*----------private----------*/ 
   private int m_uiTime;
   private int m_uiTime_Second_Tensplace;
   private int m_uiTime_Second_Onesplace;
   [SerializeField] private Text timerText;
   [SerializeField] private Image[] m_ui_ImageComp = new Image[2];
   [SerializeField] private Sprite[] m_uiTimeSprite = new Sprite[10];
   [SerializeField] private DefaultBattleGUI defaultBattleGUI;

    // Start is called before the first frame update
    void Start()
    {
        GameObject StartObj = GameObject.Find("StartCommand");
        _SecondCalculation(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (m_uiTime > 0)
        {
            _SecondCalculation(false);
        }
    }

    void _SecondCalculation(bool Start)
    {
        //Debug.Log(timerText.text.ToString());

        // スタート時の初期化以外の時は時間を減らす
        m_uiTime = int.Parse(timerText.text.ToString());

        /*秒（10桁）*/
        m_uiTime_Second_Tensplace = m_uiTime / 10;

        /*秒（1桁）*/
        m_uiTime_Second_Onesplace = m_uiTime % 60 % 10;

        // 画像を変更
        _SpriteDisplay(0, m_uiTime_Second_Tensplace);

        _SpriteDisplay(1, m_uiTime_Second_Onesplace);
    }
    void _SpriteDisplay(int DisplyObjectNum, int Time)
    {
        m_ui_ImageComp[DisplyObjectNum].sprite = m_uiTimeSprite[Time];
    }
}
