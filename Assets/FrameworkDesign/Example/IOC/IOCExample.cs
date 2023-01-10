using System;
using UnityEditor.MemoryProfiler;
using UnityEngine;

namespace FrameworkDesign.Example.IOC
{
    public class IOCExample : MonoBehaviour
    {
        private void Start()
        {
            var container = new IOCContainer();
            container.Register<IBluetoothManager>(new  BluetoothManager());

            IBluetoothManager bluetoothManager = container.Get<IBluetoothManager>();
           
           bluetoothManager.Connect();
        }
        
        public interface IBluetoothManager
        {
            void Connect();
        }
        
        public class BluetoothManager:IBluetoothManager
        {
            public void Connect()
            {
                Debug.Log("蓝牙连接成功");
            }
        }
        
    }
}