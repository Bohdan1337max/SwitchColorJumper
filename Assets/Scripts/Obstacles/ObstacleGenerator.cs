using UnityEngine;
namespace Obstacles
{
    public abstract class ObstacleGenerator : MonoBehaviour
    {
        public abstract IObstacle CreateObstacle(float currentPlayerPosition);
    }
    
}