using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSetting : MonoBehaviour
{
    [SerializeField]
    private float stageCammeraFarClipPlane = 100;
    //カメラの
    //位置
    [SerializeField]
    private Vector3 stageCameraTransform = new Vector3(0, 9, -53);
    //カメラの回転
    [SerializeField]
    private Vector3 stageCameraRotation = new Vector3(7, 0, 0);
    //見ているかどうか
    private bool stageCamEnableLookAt = true;
    //ズームが有効かどうか
    private bool stageCamEnableZoom = true;
    //ズーム距離
    private float stageCamFieldOfView = 12;
    //最小ズーム距離
    [SerializeField]
    private float stageCamMinimumZoom = 40;
    //最大ズーム距離
    [SerializeField]
    private float stageCamMaximumZoom = 60;
    //プレイヤーとカメラの距離
    [SerializeField]
    private float stageCamMaximumPlayerDistance = 18;


    private void Awake()
    {
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().farClipPlane = stageCammeraFarClipPlane;

        //UFEのカメラにそれぞれの設定を適応
        UFE.config.cameraOptions.initialDistance = stageCameraTransform;
        UFE.config.cameraOptions.initialRotation = stageCameraRotation;
        UFE.config.cameraOptions.enableLookAt = stageCamEnableLookAt;
        UFE.config.cameraOptions.initialFieldOfView = stageCamFieldOfView;
        UFE.config.cameraOptions.minZoom = stageCamMinimumZoom;
        UFE.config.cameraOptions.maxZoom = stageCamMaximumZoom;
        UFE.config.cameraOptions.enableZoom = stageCamEnableZoom;
        UFE.config.cameraOptions._maxDistance = stageCamMaximumPlayerDistance;
    }
}
