using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;

public static class TMP_TextExtensionMethods
{
    public static float GetLocalEdgeLeft(this TMP_Text self)
    {
        return self.transform.localPosition.x + self.textInfo.characterInfo.Min(x => x.bottomLeft.x);
    }

    public static float GetLocalEdgeBottom(this TMP_Text self)
    {
        return self.transform.localPosition.y + self.textInfo.characterInfo.Min(x => x.bottomLeft.y);
    }

    public static float GetLocalEdgeRight(this TMP_Text self)
    {
        return self.transform.localPosition.x + self.textInfo.characterInfo.Max(x => x.topRight.x);
    }

    public static float GetLocalEdgeTop(this TMP_Text self)
    {
        return self.transform.localPosition.y + self.textInfo.characterInfo.Max(x => x.topRight.y);
    }

    public static float GetEdgeLeft(this TMP_Text self)
    {
        return self.transform.TransformPoint(self.textInfo.characterInfo.Min(x => x.bottomLeft.x), 0, 0).x;
    }

    public static float GetEdgeBottom(this TMP_Text self)
    {
        return self.transform.TransformPoint(0, self.textInfo.characterInfo.Min(x => x.bottomLeft.y), 0).y;
    }

    public static float GetEdgeRight(this TMP_Text self)
    {
        return self.transform.TransformPoint(self.textInfo.characterInfo.Max(x => x.topRight.x), 0, 0).x;
    }

    public static float GetEdgeTop(this TMP_Text self)
    {
        return self.transform.TransformPoint(0, self.textInfo.characterInfo.Max(x => x.topRight.y), 0).y;
    }
}