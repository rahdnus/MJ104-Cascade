using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils 
{
    static Utils instance;
    public static Utils Instance{
        get{
            if(instance==null)
             instance=new Utils();
            return instance;
        }
    } 
    public SignalColor indextoSignalType(int index)
    {
        switch(index)
        {
            case 0:return SignalColor.Cyan;
            case 1:return SignalColor.Lime;
            case 2:return SignalColor.Purple;
            case 3:return SignalColor.Red;
            case 4:return SignalColor.Yellow;

            default:
                Debug.LogError("Invalid index :"+index.ToString());
                return SignalColor.Undefined;
        }
    }
}
