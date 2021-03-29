using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBase
{
    private int weight;

    public virtual int Weight { get => weight; set => weight = value; }

    public virtual bool CheckTrigger()
    {
        return false;
    }
}
