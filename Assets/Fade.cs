using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    public Image fadePanel;             // フェード用のUIパネル（Image）
    public float fadeDuration = 2.0f;   // フェードの完了にかかる時間
    private Color defaultColor = Color.clear;
    private Color endColor; // フェードパネルの最終色を設定
    private bool isFade = false;

    public Fade()
    {
        this.endColor = new Color(this.defaultColor.r, this.defaultColor.g, this.defaultColor.b, 1.0f);
    }


    private void Start()
    {
        this.defaultColor = this.fadePanel.color;
    }

    public void FadeOut()
    {
        StartCoroutine(FadeOutAndLoadScene());
    }
    public void FadeClear()
    {
        this.fadePanel.color = this.defaultColor;
    }

    private IEnumerator FadeOutAndLoadScene()
    {
        isFade = true;
        yield return new WaitForSeconds(2);

        this.fadePanel.enabled = true;                 // パネルを有効化
        float elapsedTime = 0.0f;                 // 経過時間を初期化

        // フェードアウトアニメーションを実行
        while (elapsedTime < this.fadeDuration)
        {
            elapsedTime += Time.deltaTime;                        // 経過時間を増やす
            float t = Mathf.Clamp01(elapsedTime / this.fadeDuration);  // フェードの進行度を計算
            this.fadePanel.color = Color.Lerp(this.defaultColor, this.endColor, t); // パネルの色を変更してフェードアウト
            yield return null;                                     // 1フレーム待機
        }

        this.fadePanel.color = this.endColor;  // フェードが完了したら最終色に設定
        yield return new WaitForSeconds(3);
        this.fadePanel.color = this.defaultColor;  // フェードが完了したら最終色に設定
        this.isFade = false;
    }

    public bool IsFade()
    {
        return isFade;
    }
}