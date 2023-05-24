using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class ColorPalette : MonoBehaviour
    {
        public static ColorPalette Instance { get; private set; }

        public Color colorCyan;
        public Color colorYellow;
        public Color colorMagenta;
        public Color colorPink;
        
        private void Awake()
        {
            Instance = this;
        }
    }
}