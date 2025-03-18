using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace golf
{ 

public class Spawner : MonoBehaviour
{
        public GameObject stone;

        public void Spawn()
        {
            Debug.Log("Spawn");

            if (stone == null)
            {
                Debug.LogError("Spawner - stone == null");
                return;
            }
            Instantiate(stone, transform.position, Quaternion.identity);
        }
    }
}

