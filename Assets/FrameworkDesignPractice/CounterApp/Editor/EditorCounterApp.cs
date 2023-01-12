using System;
using UnityEditor;
using UnityEngine;

namespace FrameworkDesign.Practice
{
    public class EditorCounterApp : EditorWindow
    {
        [MenuItem("EditorCounterApp/Open")]
        static void Open()
        {
            var window = GetWindow<EditorCounterApp>();
            window.position = new Rect(100, 100, 400, 600);
            window.titleContent = new GUIContent(nameof(EditorCounterApp));
        }

        private void OnGUI()
        {
            if (GUILayout.Button("+"))
            {
                new AddCountCommand().Execute();
            }
            
            GUILayout.Label(CounterApp.Get<ICounterModel>().Count.Value.ToString());
            
            if (GUILayout.Button("-"))
            {
                new SubCountCommand().Execute();
            }
            
        }
    }
}