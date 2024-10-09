using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLogMono : MonoBehaviour
{

    public void LogMessage(string message)
    {
        Debug.Log(message,this.gameObject);
    }

    public void LogWarning(string message)
    {
        Debug.LogWarning(message,this.gameObject);
    }
    public void LogError(string message)
    {
        Debug.LogError(message,this.gameObject);
    }

}
