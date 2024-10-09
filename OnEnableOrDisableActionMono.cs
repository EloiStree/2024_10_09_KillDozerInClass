using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnEnableOrDisableActionMono : MonoBehaviour
{
    public UnityEvent m_onEnable;
    public UnityEvent m_onDisable;

    void OnEnable()
    {
        m_onEnable.Invoke();
    }
    void OnDisable()
    {
        m_onDisable.Invoke();
    }
}
