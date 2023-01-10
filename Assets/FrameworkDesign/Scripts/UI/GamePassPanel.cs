using System;
using UnityEngine;

namespace FrameworkDesign.Example
{
    public class GamePassPanel : MonoBehaviour
    {
        private void Awake()
        {
            GamePassEvent.Register(OnGamePass);
        }
        private void OnGamePass()
        {
            transform.Find("Canvas/GamePassPanel").gameObject.SetActive(true);
        }
        private void OnDestroy()
        {
            GamePassEvent.UnRegister(OnGamePass);
        }
        
    }
}