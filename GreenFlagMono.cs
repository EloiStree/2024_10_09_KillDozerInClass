using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GreenFlagMono : MonoBehaviour
{
    public UnityEvent m_onGameStart;
    void Start()
    {
        RestartTheGame();
    }

    [ContextMenu("Reset the game")]
    void RestartTheGame() {
        m_onGameStart.Invoke();
    }


}
