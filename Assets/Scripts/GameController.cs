using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class GameController : MonoBehaviour
    {
        public MainMenu mainMenu;

        private void Start()
        {
            mainMenu.gameObject.SetActive(true);
        }
    }
}