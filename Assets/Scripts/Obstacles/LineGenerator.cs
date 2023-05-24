using System;
using UnityEngine;

namespace Obstacles
{
    public class LineGenerator : ObstacleGenerator
    {
        public Line LinePrefab;
        public GameObject ColorChanger;
        public float LineOffset;
        public float ColorChangerOffset;
        
        public static LineGenerator Instance { get; private set;}
        public override IObstacle CreateObstacle(float currentPlayerPosition)
        {
            Instantiate(ColorChanger, new Vector3(0f, currentPlayerPosition + ColorChangerOffset), Quaternion.identity);
            
            return Instantiate(LinePrefab, new Vector3(0f, currentPlayerPosition + LineOffset), Quaternion.identity);
        }

        private void Awake()
        {
            Instance = this;
        }
    }
}