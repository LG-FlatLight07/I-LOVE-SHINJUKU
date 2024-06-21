using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneralMapLoader : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        //VSザコ開始シーンを開く
        if (Input.GetKeyDown("1"))
        {
            SceneManager.LoadScene("1_VSMobMatching"); 
        }
        
        //VSザコシーンリザルトシーンを開く
        if (Input.GetKeyDown("2"))
        {
            SceneManager.LoadScene("3_VSMobResult"); 
        }
        
        //VSカガミ1回目リザルトシーンを開く
        if (Input.GetKeyDown("3"))
        {
            SceneManager.LoadScene("6_VSKagami1Result"); 
        }
    }
}
