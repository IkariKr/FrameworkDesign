using UnityEngine;

namespace FrameworkDesign.Practice
{
    public interface IStorage
    {
        void SaveInt(string key, int value);
        int LoadInt(string value, int defaultValue = 0);
    }
    
}