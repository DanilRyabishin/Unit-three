using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace Golf
{
    public class MainMenu : GameState
    {
        public GameState gamePlay;
        public LevelController levelController;
        public TMP_Text scoreText;

        public void PlayGame()
        {
            Exit();
            gamePlay.Enter();
        }
        protected override void OnEnable()
        {
            base.OnEnable();
            scoreText.text = $"HScore : {levelController.highScore}";
        }
    }
}
