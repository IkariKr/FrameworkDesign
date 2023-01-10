using System;
using UnityEngine;

namespace FrameworkDesign.Example.Game
{

    namespace FrameworkDesign.Example
    {
        public class Game : MonoBehaviour
        {
            private void Awake()
            {
                GameStartEvent.Register(OnGameStart);
            }


            
            private void OnGameStart()
            {
                transform.Find("Enemies").gameObject.SetActive(true);
            }

            private void OnDestroy()
            {
                GameStartEvent.UnRegister(OnGameStart);
            }
        }
    }

}