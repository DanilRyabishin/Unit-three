using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace golf
{ 
public class CloudController : MonoBehaviour
    {
        private int m_targInd = 0;
        private bool m_moved = false;
        public float moveSpd = 10f;
        public Cloud cloud;
        public Transform[] targests;

        public void Action()
        {
            Debug.Log("Cloud", this);

            if (m_moved)
            {
                return;
            }
            m_moved = true;
            cloud.StopFX();
            m_targInd++;

            if (m_targInd >= targests.Length) 
            { 
                m_targInd = 0; 
            }
        }
        public void Update()
        {
            if (!m_moved)
            {
                return;
            }

            Transform target = targests[m_targInd];
            Vector3 targetPos = new Vector3(target.position.x, cloud.transform.position.y, target.position.z);
            Vector3 offset = (targetPos - cloud.transform.position).normalized * Time.deltaTime * moveSpd;
            float distance = Vector3.Distance(cloud.transform.position, targetPos);

            if (distance < offset.magnitude)
            {
                cloud.transform.position = targetPos;
                m_moved = false;
                cloud.PlayFX();
            }
            else
            {
                cloud.transform.Translate(offset);
            }
        }
    }
}