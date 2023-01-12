using System;
using UnityEngine;

namespace FrameworkDesign.Practice
{
    public class UI : MonoBehaviour
    {
        private GameObject GamePassPanel;

        private void Awake()
        {
            GamePassPanel = transform.Find("Canvas/GamePassPanel").gameObject;
            
            GamePassEvent.Register(OnGamePass);
        }

        private void OnGamePass()
        {
            GamePassPanel.SetActive(true);
        }
    }
}