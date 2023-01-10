using UnityEditor;
using UnityEngine;

namespace CounterApp.Editor
{
    public class EditorCounterApp : EditorWindow //编辑器窗口
    {
        private static ICounterModel mCounterModel;
        [MenuItem("EditorConterApp/Open")]
        static void Open()
        {
            mCounterModel = CounterApp.Get<ICounterModel>();
            
            var window = GetWindow<EditorCounterApp>();
            window.position = new Rect(100, 100, 400, 600);
            window.titleContent = new GUIContent(nameof(EditorCounterApp));
            window.Show();
            
        }

        private void OnGUI()
        {
            if (GUILayout.Button("+"))
            {
                new AddCountCommand().Execute();
            }
            
            GUILayout.Label(mCounterModel.Count.Value.ToString());
            
            if (GUILayout.Button("-"))
            {
                new SubCountCommand().Execute();
            }
        }
    }
}

