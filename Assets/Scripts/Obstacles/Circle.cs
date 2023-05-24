using UnityEngine;

namespace Obstacles
{
    public class Circle : MonoBehaviour, IObstacle
    {
        public float speed = 100f;
        
        public void Rotate()
        {
            transform.Rotate(0f,0f,speed * Time.deltaTime);
        }
    }
}