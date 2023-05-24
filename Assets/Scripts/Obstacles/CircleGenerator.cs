using System;
using UnityEngine;

namespace Obstacles
{
    public class CircleGenerator : ObstacleGenerator
    {
        public Circle CirclePrefab;
        public GameObject ColorChanger;
        public float CircleOffset;
        public float ColorChangerOffset;
        public static CircleGenerator Instance { get; private set;}
        public override IObstacle CreateObstacle(float currentPlayerPosition)
        {

            Instantiate(ColorChanger, new Vector3(0f, currentPlayerPosition + ColorChangerOffset), Quaternion.identity);
            
            return Instantiate(CirclePrefab, new Vector3(0f, currentPlayerPosition + CircleOffset), Quaternion.identity);
        }

        private void Awake()
        {
            Instance = this;
        }
    }
}