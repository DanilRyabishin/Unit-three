using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
     
public class LevelController : MonoBehaviour
{
        public Spawner spawner;
        public float delay = 1.4f;
        public bool gameOver = false;

        private void Start()
        {
            StartCoroutine(startStoneProc());
        }

        private IEnumerator startStoneProc()
        {
            do
            {
                yield return new WaitForSeconds(delay);
                spawner.Spawn();
            }
            while (!gameOver);
        }
    }

}
