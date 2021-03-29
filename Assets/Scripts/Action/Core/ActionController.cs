using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionController : MonoBehaviour
{
    private List<ActionBase> actionList;
    private ActionBase curAction;
    public AnimalController animal;

    private void Awake()
    {
        actionList = new List<ActionBase>();
        foreach (var action in actionList)
        {
            action.Init(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var action in actionList)
        {
            if (action != curAction)
            {
                foreach (var trigger in action.triggerList)
                {
                    if (trigger.CheckTrigger())
                    {
                        action.OnActionEnter();
                        if (curAction!=null)
                        {
                            curAction.OnActionExit();
                        }
                        curAction = action;
                    }
                }

            }
        }
        if (curAction!=null)
        {
            curAction.OnActionUpdate();
        }
    }
}
