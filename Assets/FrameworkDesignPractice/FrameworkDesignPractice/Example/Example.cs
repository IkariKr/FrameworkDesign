using System;
using UnityEngine;

namespace FrameworkDesignPractice.Example
{
    public class Example : MonoBehaviour
    {
        private IOCContainer _iocContainer;

        private void Start()
        {
            _iocContainer = new IOCContainer();
            _iocContainer.Register(new BluetoothManager());

            BluetoothManager bluetoothManager = _iocContainer.Get<BluetoothManager>();
            
            bluetoothManager.Connect();
        }

        public class BluetoothManager
        {
            public void Connect()
            {
                Debug.Log("蓝牙连接成功");
            }
        }

    }
}