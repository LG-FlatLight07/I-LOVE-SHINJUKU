using UnityEngine;
using System.Collections.Generic;
using UFE3D;

public class DefaultContinueScreen : StoryModeContinueScreen
{
    public AudioClip countdownSound;

    #region public override methods
    public override void OnShow()
    {
        base.OnShow();
        if (this.countdownSound != null)
        {
            UFE.DelayLocalAction(delegate () { UFE.PlaySound(this.countdownSound); }, this.delayBeforePlayingMusic);
        }
    }
    #endregion
}
