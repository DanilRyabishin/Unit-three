using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace golf
{
    public class Cloud : MonoBehaviour
    {
        [SerializeField] private ParticleSystem particleSystem;

        public void PlayFX()
        {
            particleSystem.Play();
        }
        public void StopFX()
        {
            particleSystem.Stop();
        }
        public void Start()
        {
            particleSystem.Stop();
        }
    }
}
