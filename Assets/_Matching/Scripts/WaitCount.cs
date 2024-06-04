using UnityEngine;
using UnityEngine.UI;

//待ち時間処理
public class WaitCount : MonoBehaviour
{
    [SerializeField] //秒数カウント
    private double countSeconds = 0.0f;
    [SerializeField] //分数カウント
    private int countMinutes = 0;
    [SerializeField] //カウントテキスト
    private Text waitText;
    void Start()
    {
        if (!waitText) return;
        waitText = GetComponent<Text>();
    }

    void Update()
    {
        CountUp();
    }
    
    //カウントアップする関数
    void CountUp()
    {
        //60秒になったら
        if (countSeconds >= 60.0f)
        {
            countSeconds = 0.0f;
            countMinutes += 1;
            waitText.text = countMinutes.ToString("D3");
        }
        countSeconds += Time.deltaTime;
        int remaining = (int)countSeconds;
        waitText.text = remaining.ToString("00:00");
    }
}
