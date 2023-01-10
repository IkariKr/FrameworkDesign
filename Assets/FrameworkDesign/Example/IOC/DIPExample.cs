#if UNITY_EDITOR
using UnityEditor;
#endif
using Unity.VisualScripting;
using UnityEngine;

namespace FrameworkDesign.Example
{
    public class DIPExample :MonoBehaviour
    {
        public interface IStorage
        {
            void SaveSting(string key, string value);
            string LoadString(string key, string defaultValue = "");
        }
        
        public class PlayerPrefsStorage : IStorage
        {
            public void SaveSting(string key, string value)
            {
                PlayerPrefs.SetString(key, value);
            }

            public string LoadString(string key, string defaultValue = "")
            {
                return PlayerPrefs.GetString(key, defaultValue);
            }
        }

        public class EditorPrefsStorage : IStorage
        {
            public void SaveSting(string key, string value)
            {
#if UNITY_EDITOR
                EditorPrefs.GetString(key, value);
#endif
                
            }

            public string LoadString(string key, string defaultValue = "")
            {
#if UNITY_EDITOR
                return EditorPrefs.GetString(key, defaultValue);
#else
return "";
#endif
            }
        }

        void Start()
        {
            var container = new IOCContainer();

            container.Register<IStorage>(new PlayerPrefsStorage());

            var storage = container.Get<IStorage>();

            storage.SaveSting("name","运行时存储");

            Debug.Log(storage.LoadString("name"));
            
            container.Register<IStorage>(new EditorPrefsStorage());

            storage = container.Get<IStorage>();
            
            Debug.Log(storage.LoadString("name"));
        }
        
    }
}