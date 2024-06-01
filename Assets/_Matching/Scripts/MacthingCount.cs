using UnityEngine;
using UnityEngine.UI;

//マッチングのカウント処理
public class MacthingCount : MonoBehaviour
{
    [SerializeField] //秒数カウント
    private float countSeconds = 10.0f;
    [SerializeField] //カウントテキスト
    private Text countText;
    void Start()
    {
        if (!countText) return;
        countText = GetComponent<Text>();
    }
    
    void Update()
    {
        CountDown();
    }

    //カウントダウンする関数
    void CountDown()
    {
        //0秒以下になったら
        if (countSeconds < 0) return;
        
        countSeconds -= Time.deltaTime;
        int remaining = (int)countSeconds;
        countText.text = remaining.ToString("");
    }
}
