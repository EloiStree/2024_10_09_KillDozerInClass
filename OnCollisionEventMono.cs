using Eloi;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


//[RequireComponent(typeof(Collider))]
public class OnCollisionEventMono : MonoBehaviour
{

    public UnityEvent m_onCollisionEnter;
    public UnityEvent m_onCollisionExit;

    public UnityEvent m_onTriggerEnter;
    public UnityEvent m_onTriggerExit;

    public LayerMask m_whatToAllows;

    public void OnCollisionEnter(Collision collision)
    {
            if(IsTargetInLayer(collision))
                m_onCollisionEnter.Invoke();
    }
    public void OnCollisionExit(Collision collision)
    {
        if (IsTargetInLayer(collision))
            m_onCollisionExit.Invoke();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (IsTargetInLayer(other))
            m_onTriggerEnter.Invoke();
    }
    public void OnTriggerExit(Collider other)
    {
        if (IsTargetInLayer(other))
            m_onTriggerExit.Invoke();
    }
    private bool IsTargetInLayer(Collision collision)
    {
        return IsTargetInLayer(collision.gameObject);
    }
    private bool IsTargetInLayer(Collider batman)
    {
        return IsTargetInLayer(batman.gameObject);
    }
    private bool IsTargetInLayer(GameObject target)
    {
        return m_whatToAllows == (m_whatToAllows | (1 << target.layer));
    }


    public void Reset()
    {
        CheckForCollider();
    }

    public void Start()
    {
        CheckForCollider();
    }

    private void CheckForCollider()
    {
        Collider c = GetComponent<Collider>();
        if (c == null)
        {
            //this.gameObject.AddComponent<SphereCollider>();
            Debug.LogError("OnCollisionEventMono need a collider to work",
                this.gameObject);
        }
    }
}
