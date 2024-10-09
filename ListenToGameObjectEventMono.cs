using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ListenToGameObjectEventMono : MonoBehaviour
{
    public UnityEvent m_onAwake;
    void Awake() => m_onAwake.Invoke();
    public UnityEvent m_onEnable;
    void OnEnable() => m_onEnable.Invoke();
    public UnityEvent m_onStart;
    void Start() => m_onStart.Invoke();

    public UnityEvent m_onDisable;
    void OnDisable() => m_onDisable.Invoke();
    public UnityEvent m_onDestroy;
    void OnDestroy() => m_onDestroy.Invoke();
}
