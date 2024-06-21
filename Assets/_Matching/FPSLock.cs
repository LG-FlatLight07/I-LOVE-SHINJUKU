using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSLock : MonoBehaviour
{
    private void Awake()
    {
        // Vsync Count を 0にすることにより、FPS を固定できるようになる
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
    }
}
