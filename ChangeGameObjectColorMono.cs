using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGameObjectColorMono : MonoBehaviour
{

    public MeshRenderer m_toAffect;
    public Color m_colorToChangeTo;

    [ContextMenu("Change Random Color")]
    public void ChangeRandomColor() {
        m_colorToChangeTo =
            new Color(
                Random.Range(0f, 1f),
                Random.value,
                Random.value);
        m_toAffect.material.color = m_colorToChangeTo;
    }

}
