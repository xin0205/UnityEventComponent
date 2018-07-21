using GameFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEventArgs : BaseEventArgs
{

    public static readonly int EventId = typeof(ClickEventArgs).GetHashCode();

    private string clickArgs;

    public override int Id
    {
        get
        {
            return EventId;
        }
    }

    public string ClickArgs
    {
        get
        {
            return clickArgs;
        }

        set
        {
            clickArgs = value;
        }
    }

    public override void Clear()
    {
        
    }
}
