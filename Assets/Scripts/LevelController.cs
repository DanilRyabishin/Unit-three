using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{

    public class LevelController : MonoBehaviour
    {
        public Spawner spawner;
        private float delay = 2.5f;        
        private float m_lastSpawnedTime = 0;

        private void Start()
        {
            m_lastSpawnedTime = Time.time;
            Ball.onCollisionBall += GameOver;
        }
        private void OnEnable()
        {           
            Ball.onCollisionBall += GameOver;
        }
        private void OnDisable()
        {           
            Ball.onCollisionBall -= GameOver;
        }

        private void GameOver()
        {
            Debug.Log("Конец игры, пес");
            enabled = false;
        }
        
        private void Update()
        {          
                if (Time.time >= m_lastSpawnedTime + delay)
                {
                    spawner.Spawn();
                    m_lastSpawnedTime = Time.time;
                }
            
        }
    }
}
