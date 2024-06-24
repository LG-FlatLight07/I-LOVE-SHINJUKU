using System.Collections.Generic;
using UFE3D;

public class DefaultVersusModeAfterBattleScreen : VersusModeAfterBattleScreen
{
    #region public override methods
    public override void OnShow()
    {
        //base.OnShow();
    }

    private void Start()
    {

        if (GeneralMapLoader.instance)
        {
            GeneralMapLoader.instance.versus = this;
        }
    }

    // Override constructor and don't call base
    public override void DoFixedUpdate(
        IDictionary<InputReferences, InputEvents> player1PreviousInputs,
        IDictionary<InputReferences, InputEvents> player1CurrentInputs,
        IDictionary<InputReferences, InputEvents> player2PreviousInputs,
        IDictionary<InputReferences, InputEvents> player2CurrentInputs
    )
    { }
    #endregion
}
