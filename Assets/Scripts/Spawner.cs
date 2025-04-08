using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{ 

public class Spawner : MonoBehaviour
{
        public GameObject[] golf_ball;

        public GameObject Spawn()
        {
            Debug.Log("Spawn");

            var prefab = getRandomPrefab();

            if (prefab == null)
            {
                Debug.LogError("Spawner - stone == null");
                return null;
            }
            return Instantiate(prefab, transform.position, Quaternion.identity);
          
        }
        private GameObject getRandomPrefab()
        {
            if (golf_ball.Length == 0)
            {
                Debug.Log("stones");
                return null;
            }

            int index = Random.Range(0, golf_ball.Length);
            return golf_ball[index];
        }
    }
}

