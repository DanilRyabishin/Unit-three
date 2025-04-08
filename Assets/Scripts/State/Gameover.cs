using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class Gameover : GameState
    {
        public GameState mainMenu;
        public LevelController levelController;
        public void Restart()
        {
            levelController.ClearBall();
            Exit();
            mainMenu.Enter();
        }
 
    }
}
