using UnityEngine;
using DefaultNamespace;

namespace Obstacles
{
    public class Line : MonoBehaviour, IObstacle
    {
        public Collider2D col;
        public SpriteRenderer sr;
        public float time = 0f;
        public float timeDelay = 1f;
        
       
        public void Rotate()
        {
            time +=  1f * Time.deltaTime;

            if (time >= timeDelay)
            {
                SetRandomColor();
                time = 0f;
            }
                
            
            
            
        }
        private void Start()
        {
            SetRandomColor();
        }
        void SetRandomColor()
        {
            
                int index = Random.Range(0, 4);
                switch (index)
                {
                    case 0:
                        col.tag = "Cyan";
                        sr.color = ColorPalette.Instance.colorCyan;
                        break;
                    case 1:
                        col.tag = "Yellow";
                        sr.color = ColorPalette.Instance.colorYellow;
                        break;
                    case 2:
                        col.tag = "Magenta";
                        sr.color = ColorPalette.Instance.colorMagenta;
                        break;
                    case 3:
                        col.tag = "Pink";
                        sr.color = ColorPalette.Instance.colorPink;
                        break;
                
                }
            }
    }
}