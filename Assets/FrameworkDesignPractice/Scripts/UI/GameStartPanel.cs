using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FrameworkDesign.Practice
{
    public class GameStartPanel : MonoBehaviour
    {
        private Button btnStart;

        void Start()
        {
            btnStart = transform.Find("BtnStart").GetComponent<Button>();
            btnStart.onClick.AddListener(() =>
            {
                gameObject.SetActive(false);
                GameStartEvent.Trigger();
            });
        }
        

    }
}
