using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace golf
{ 
    public class PlayerController : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                Debug.Log("X key down");
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Debug.Log("Z key down");
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space key down");
            }
        }

    }
}