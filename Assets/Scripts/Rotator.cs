 using System;
 using UnityEngine;
using Obstacles;
public class Rotator : MonoBehaviour
{
    public IObstacle Obstacle;
    void Update()
    {
            Obstacle?.Rotate();
    }

    private void Start()
    {
        Obstacle = GetComponent<IObstacle>();
    }
}
