using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Eloi
{
    [HelpURL("https://github.com/EloiStree/2024_10_09_KillDozerInClass")]
    [SelectionBase]
    public class KillDozerMono : MonoBehaviour
    {


        /// <summary>
        /// This is the rotation of the Kill Dozer in angle left to right.
        /// </summary>
        [Tooltip("This rotation is in angle around Y axis")]
        public float m_rotationLeftRight=90f;

        [Space(20)]
        [Tooltip("This is speed in meter to go forward")]
        public float m_frontalSpeed=0.2f;
        [Tooltip("This is speed in meter to go backward")]
        public float m_backSpeed=0.1f;

        [Header("Percent Joystick")]
        [Range(-1,1)]
        [SerializeField]
        [ContextMenuItem("Random Axis", "RandomLeftRightAxis")]
        float m_rotateLeftRightPercent;

        [Range(-1, 1)]
        [SerializeField]
        [ContextMenuItem("Random Axis", "RandomDownUpAxis")]
        float m_moveFrontBackPercent;

        public Transform m_whatToMove;
       


        void RandomLeftRightAxis() => m_rotateLeftRightPercent = UnityEngine.Random.Range(-1f, 1f);
        void RandomDownUpAxis() => m_moveFrontBackPercent = UnityEngine.Random.Range(-1f, 1f);


        [ContextMenu("Open Documentation")]
        public void OpenDocumentatoin() {

            Application.OpenURL("https://github.com/EloiStree/2024_10_09_KillDozerInClass");
        }

        private void Reset()
        {
            m_whatToMove = transform;

        }

        [ContextMenu("Set Random Input")]
        public void SetRandomInput()
        {

            m_moveFrontBackPercent = UnityEngine.Random.Range(-1f, 1f);
            m_rotateLeftRightPercent = UnityEngine.Random.Range(-1f, 1f);
        }
        [ContextMenu("Set  Input To Zero")]
        public void SetInputToZero()
        {

            m_moveFrontBackPercent = 0;
            m_rotateLeftRightPercent = 0;
        }

        public void SetRotateLeftRightPercent(float percent11)
        {
            if (percent11 > 1)
                percent11 = 1;
            if (percent11 < -1)
                percent11 = -1;
            m_rotateLeftRightPercent = percent11;
        }
        public void SetMoveBackForwardPercent(float percent11)
        {
            percent11 = Eloi.EloiMathToolbox.Clamp(percent11, -1, 1);
            m_moveFrontBackPercent = percent11;
        }

        public void GetJoystickValue(
            out float leftRightPercent11
            , out float forwardPercent11)
        {
            leftRightPercent11 = m_rotateLeftRightPercent;
            forwardPercent11 = m_moveFrontBackPercent;
        }


        public void GetMoveBackForwardPercent(out float forwardPercent11) { 
        
            forwardPercent11 = m_moveFrontBackPercent;
        }

        public float GetRotateLeftRightPercent()
        {
            return m_rotateLeftRightPercent;
        }
        public float GetMoveBackForwardPercent()
        {
            return m_moveFrontBackPercent;
        }




        void Update()
        {
            //rotation
            float rotation = m_rotationLeftRight
                * m_rotateLeftRightPercent;
            m_whatToMove.Rotate(0, rotation * Time.deltaTime, 0);

            //translation
            float speed = GetSpeedFront();
            m_whatToMove.Translate(0, 0, m_moveFrontBackPercent
                * speed * Time.deltaTime);
        }

        private float GetSpeedFront()
        {
            return m_moveFrontBackPercent >
                            0 ? m_frontalSpeed : m_backSpeed;
        }
    }



    public class EloiMathToolbox
    {

        public static float Clamp(float value,
            float minValue,
            float maxValue)
        {

            if (value > 1)
                value = 1;
            if (value < -1)
                value = -1;
            return value;

        }
    }
}
