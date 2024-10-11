using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnCollisionEnterWithPlayerScriptMono : MonoBehaviour
{

    public UnityEvent m_onCollisionDetected;
    public LayerMask m_whatToAllow;
    public void OnCollisionEnter(Collision collision)
    {
        if(!IsTargetInLayer(collision.gameObject))
            return;
        if (null==collision.gameObject.GetComponent<PlayerScriptTagMono>())
            return;
         m_onCollisionDetected.Invoke();
    }
    private bool IsTargetInLayer(GameObject target)
    {
        return m_whatToAllow == (m_whatToAllow | (1 << target.layer));
    }
}
