using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxSetting : MonoBehaviour
{
    [SerializeField] 
    private Material skyBoxMaterial;

    private void Awake()
    {
        if (skyBoxMaterial == null) return
                ;
        //スカイボックスのマテリアル変更
        RenderSettings.skybox = skyBoxMaterial;
    }
}
