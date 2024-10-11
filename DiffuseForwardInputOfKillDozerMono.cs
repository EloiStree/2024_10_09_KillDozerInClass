using Eloi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DiffuseForwardInputOfKillDozerMono : MonoBehaviour
{
    public KillDozerMono m_killDozer;
    public float m_backForwardState = 0.1f;
    public UnityEvent<float> m_onValuePushed;

    public Vector2 m_joystickState;

    void Update()
    {

        //m_backForwardState = m_killDozer.GetMoveBackForwardPercent();
        m_killDozer.GetMoveBackForwardPercent(out m_backForwardState);
        m_killDozer.GetJoystickValue(out m_joystickState.x, out m_joystickState.y);
        m_onValuePushed.Invoke(m_backForwardState);

        
    }
}
