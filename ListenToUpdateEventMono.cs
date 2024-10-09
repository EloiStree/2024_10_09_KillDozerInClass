using UnityEngine;
using UnityEngine.Events;

public class ListenToUpdateEventMono : MonoBehaviour {

    public UnityEvent m_onUpdate;
    public UnityEvent m_onFixedUpdate;
    public UnityEvent m_onLateUpdate;

    public void Update()=> m_onUpdate.Invoke();
    public void FixedUpdate()=> m_onFixedUpdate.Invoke();
    public void LateUpdate()=> m_onLateUpdate.Invoke();
}