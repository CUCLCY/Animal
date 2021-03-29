using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionBase
{
    public List<TriggerBase> triggerList;

    public ActionController controller;

    public virtual void Init(ActionController controller)
    {
        this.controller = controller;
    }
        
    public virtual void OnActionEnter()
    {

    }

    public virtual void OnActionUpdate()
    {

    }

    public virtual void OnActionExit()
    {

    }
}
