using UnityEditor;
using UnityEngine;

namespace FrameworkDesign.Practice
{
    public class PlayerPrefsStorage :IStorage
    {
        public void SaveInt(string key, int value)
        {
            PlayerPrefs.SetInt(key,value);
        }

        public int LoadInt(string value, int defaultValue = 0)
        {
            return PlayerPrefs.GetInt(value, defaultValue);
        }
    }
    
    public class EditorPrefsStorage :IStorage
    {
        public void SaveInt(string key, int value)
        {
            EditorPrefs.SetInt(key,value);
        }

        public int LoadInt(string value, int defaultValue = 0)
        {
            return EditorPrefs.GetInt(value, defaultValue);
        }
    }
}