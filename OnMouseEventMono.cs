using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnMouseEventMono : MonoBehaviour
{
    public UnityEvent m_onMouseDown;
    public UnityEvent m_onMouseUp;

    public UnityEvent m_onMouseEnter;
    public UnityEvent m_onMouseExit;

    private void OnMouseDown()
    {
        m_onMouseDown.Invoke();
    }

    private void OnMouseUp()
    {
        m_onMouseUp.Invoke();
    }

    private void OnMouseEnter()
    {
        m_onMouseEnter.Invoke();
    }

    private void OnMouseExit()
    {
        m_onMouseExit.Invoke();
    }
    

}
