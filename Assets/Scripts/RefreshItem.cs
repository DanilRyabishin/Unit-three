using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace golf
{
    public class RefreshItem : MonoBehaviour
    {
        public List<GameObject> tools;

        private void Start()
        {
            Changetool();
        }
        public void Changetool()
        {
            var index = Random.Range(0, tools.Count);
            SetActiveTool(index);
        }    
        private void SetActiveTool(int index)
        {
            for (int i = 0; i < tools.Count; i++)
            {
                tools[i].SetActive(i == index);
            }    
        }

    }
}

