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
        public Transform cloud;
        public Transform[] targests;
        public void Awake()
        {
            Debug.Log("Cloud", this);

            if (m_moved);
            {
                return;
            }
            m_moved = true;
            m_targInd++;
            if (m_targInd >= targests.Length) { m_targInd = 0; }
        }
        public void Update()
        {
            if (!m_moved)
            {
                return;
            }

            Transform target = targests[m_targInd];
            Vector3 targetPos = new Vector3(target.position.x, cloud.position.y, target.position.z);
            Vector3 offset = (targetPos - cloud.position).normalized * Time.deltaTime * moveSpd;

            if (Vector3.Distance(transform.position, targetPos) < offset.magnitude)
            {
                cloud.position = targetPos;
                m_moved = false;
            }
            else
            {
                cloud.Translate(offset);
            }
        }
    }

}
