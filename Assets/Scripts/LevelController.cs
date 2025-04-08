using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{

    public class LevelController : MonoBehaviour
    {
        public Spawner spawner;

        public float delayMax = 4f;
        public float delayMin = 0.3f;
        public float delayStep = 0.1f;
        private float m_delay = 2.0f;        
        private float m_lastSpawnedTime = 0;

        public int score = 0;
        public int highScore = 0;

        private List<GameObject> m_ball = new List<GameObject>(16);


        private void Start()
        {
            m_lastSpawnedTime = Time.time;
            RefreshDelay();
        }

        private void OnStickHit()
        {
            score++;
            highScore = Mathf.Max(highScore, score);
            Debug.Log($"score: {score} - highScore: {highScore}");
        }

        private void OnEnable()
        {           
            GameEvents.onStickHit += OnStickHit;
            score = 0;
        }
        private void OnDisable()
        {           
            GameEvents.onStickHit -= OnStickHit;
        }

        private void GameOver()
        {
            Debug.Log("Конец игры!");
            enabled = false;
        }

        public void ClearBall()
        {
            foreach (var ball in m_ball)
            {
                Destroy(ball);
            }
            m_ball.Clear();
        }
        public void RefreshDelay()
        {
            m_delay = UnityEngine.Random.Range(delayMin, delayMax);
            delayMax = Mathf.Max(delayMin, delayMax - delayStep);
        }
        
        private void Update()
        {          
                if (Time.time >= m_lastSpawnedTime + m_delay)
                {
                    var ball = spawner.Spawn();
                    m_ball.Add(ball);
                    m_lastSpawnedTime = Time.time;
                RefreshDelay();
                }
            
        }
    }
}
