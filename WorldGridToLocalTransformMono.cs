using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGridToLocalTransformMono : MonoBehaviour
{
    public WorldGridPositionMoveMono m_source;
    public Transform m_whatToMove;

    private void Reset()
    {
        m_source = GetComponent<WorldGridPositionMoveMono>();
        m_whatToMove = transform;
    }

    public void OnEnable()
    {
        m_source.AddChangedListener(RefreshPosition);

    }
    public void OnDisable()
    {
        m_source.RemoveChangedListener(RefreshPosition);
    }

    private void OnValidate()
    {
        RefreshPosition();
    }

    [ContextMenu("Refresh")]
    public void RefreshPosition() {

        if (m_source == null)
            return;

        if (m_whatToMove==null)
            return;
        
        m_source.GetCurrentRotation(out CubeOnGridRotation rotation);
        float yAngle = 0;
        switch (rotation) {

            case CubeOnGridRotation.Forward: yAngle = 0; break;
            case CubeOnGridRotation.Right: yAngle = 90; break;
            case CubeOnGridRotation.Backward: yAngle = 180; break;
            case CubeOnGridRotation.Left: yAngle = 270; break;
            default: break;

        }
        m_whatToMove.localPosition = new Vector3(m_source.m_xLeftToRight, m_source.m_yDownToUp, m_source.m_zBackToFront);
        m_whatToMove.localRotation = Quaternion.Euler(0, yAngle, 0);

    }

    
}
