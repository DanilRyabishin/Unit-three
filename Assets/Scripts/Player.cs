using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class Player : MonoBehaviour
    {
        public Transform stick;
        public Transform helper;
        private Vector3 m_lastPos;
        private bool m_isDown = false;
        public float range = 35f;
        public float speed = 1000f;
        public float power = 17f;

        private void Update()
        {
            m_lastPos = helper.position;
            
            Quaternion rot = stick.localRotation;
            Quaternion toRot = Quaternion.Euler(m_isDown ? range : -range, 0, 0);
            rot = Quaternion.RotateTowards(rot, toRot, speed * Time.deltaTime);
            stick.localRotation = rot;
        }

        public void SetDown(bool value)
        {
            m_isDown = value;
            Debug.Log("SertDown Call: m_isDown = " + m_isDown);
        }
        public void OnCollisionStick(Collider collider)
        {
            if (collider.TryGetComponent(out Rigidbody golf_ball))
            {
                var dir = (helper.position - m_lastPos).normalized;
                golf_ball.AddForce(dir * power, ForceMode.Impulse);

                if (collider.TryGetComponent(out Ball ball) && !ball.isAffect)
                {
                    ball.isAffect = true;
                    GameEvents.StickHit();
                }
            }

            Debug.Log(collider, this);
        }
    }
}

