using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FrameworkDesign.Example
{
    public class Enemy : MonoBehaviour
    {
        private void OnMouseDown()
        {
            Destroy(gameObject);
            new KillEnemyCommand().Execute();
        }
    }
}


