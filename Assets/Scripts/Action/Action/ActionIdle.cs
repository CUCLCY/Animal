using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionIdle : ActionBase
{

    public override void OnActionEnter()
    {
        base.OnActionEnter();
        controller.animal.PlayAnim("Idle");
    }

    public override void OnActionUpdate()
    {
        base.OnActionUpdate();
    }

    public override void OnActionExit()
    {
        base.OnActionExit();
    }
}
