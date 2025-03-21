using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace golf
{ 
    public class PlayerController : MonoBehaviour
    {
        public Spawner stone;
        public CloudController cloudController;
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                Debug.Log("X key down");
                stone.Spawn();
            }

            if (Input.GetKeyDown(KeyCode.Z))
                
            {
                cloudController.Action();
                Debug.Log("Z key down");
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space key down");
            }
        }

    }
}