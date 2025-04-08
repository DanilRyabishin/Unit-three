using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Golf
{
    public class Gameplay : GameState
    {
        public LevelController levelController;
        public PlayerController playerController;
        public GameState gameOver;
        public TMP_Text scoreText;

        protected override void OnEnable()
        {
            base.OnEnable();

            levelController.enabled = true;
            playerController.enabled = true;
            GameEvents.onCollisionBall += OnGameOver;
            GameEvents.onStickHit += OnStickHit;
        }

        private void OnStickHit()
        {
            scoreText.text = $"Score : {levelController.score}";
        }
        private void OnGameOver()
        {
            Exit();
            gameOver.Enter();
        }

        protected override void OnDisable()
        {
            base.OnDisable();

            
            levelController.enabled = false;
            playerController.enabled = false;
            GameEvents.onCollisionBall -= OnGameOver;
        }

    }
}
