using System;
using FrameworkDesignPractice.Scripts.Command;
using UnityEngine;

namespace FrameworkDesign.Practice
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