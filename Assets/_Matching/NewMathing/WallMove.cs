using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

//UIの壁動き

public class WallMove : MonoBehaviour
{
    [SerializeField]//右壁
    private RectTransform RightWall;

    [SerializeField]//左壁
    private RectTransform LeftWall;

    private void Update()
    {
        //右壁の動き
        //if (RightWall.position.x <= -270.0f)
        RightWall.position += new Vector3(-0.2f, 0, 0);
        LeftWall.position += new Vector3(0.2f, 0, 0);
        //if (LeftWall.position.x >= 270)
        //    return;
        //LeftWall.position += new Vector3(0.1f, 0, 0);
    }
}
