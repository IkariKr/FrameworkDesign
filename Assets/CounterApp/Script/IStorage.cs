using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
namespace CounterApp
{
    public interface IStorage
    {
        void SaveInt(string key, int value);
        int LoadInt(string key, int defaultvalue = 0);

    }

    public class PlayerPrefsStorage : IStorage
    {
        public void SaveInt(string key, int value)
        {
            PlayerPrefs.SetInt(key, value);
        }

        public int LoadInt(string key, int defaultvalue = 0)
        {
            return PlayerPrefs.GetInt(key, defaultvalue);
        }
    }
    
    /// <summary>
    /// 添加宏，避免打包错误
    /// </summary>
    public class EditorPrefsStorage : IStorage
    {
        public void SaveInt(string key, int value)
        {
            #if UNITY_EDITOR
            EditorPrefs.SetInt(key, value);
            #endif
        }

        public int LoadInt(string key, int defaultvalue = 0)
        {
            #if UNITY_EDITOR
            return EditorPrefs.GetInt(key, defaultvalue);
            #else
            return 0;
            #endif
        }
    }
}