using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FrameworkDesign.Example
{
    public class GameStartPanel : MonoBehaviour
    {
        private Button btnStart;
        
        // 01 父节点可以引用子节点，子节点要调用父节点的方法可以使用事件或委托。
		// 02 
        void Start()
        {
            btnStart = transform.Find("BtnStart").GetComponent<Button>();
            
            btnStart.onClick.AddListener(()=>
            {
                gameObject.SetActive(false);
                new StartGameCommand().Execute();
            });
            
        }
        
    }
}


