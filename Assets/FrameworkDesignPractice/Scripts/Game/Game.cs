using System;
using UnityEngine;

namespace FrameworkDesign.Practice
{
    public class Game : MonoBehaviour
    {
        private GameObject enemies;

        private void Awake()
        {
            enemies = transform.Find("Enemies").gameObject;
            GameStartEvent.Register(OnGameStart);
        }
        
        private void OnGameStart()
        {
            enemies.SetActive(true);
        }
    }
}