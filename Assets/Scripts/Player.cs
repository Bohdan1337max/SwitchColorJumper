using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;
using Obstacles;

public class Player : MonoBehaviour
{
    public float jumpForce = 10f;
    public bool test;
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public string currentColor;
    private void Start()
    {
        SetRandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        int index = Random.Range(0,2);
        
        if (col.tag == "ColorChanger")
        {
            SetRandomColor();
            Destroy(col.gameObject);
            switch (index)
            {
                case  0:
                    CircleGenerator.Instance.CreateObstacle(transform.position.y);
                    break;
                case 1:
                    LineGenerator.Instance.CreateObstacle(transform.position.y);
                    break;
                
            }
            return;
        }

        if (col.tag != currentColor && !test)
        {
            
            Debug.Log("GAMEOVER!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

       
    }

    void SetRandomColor()
    {
        string previousColor = currentColor;
        
        while (currentColor == previousColor)
        {
            int index = Random.Range(0, 4);
            switch (index)
            {
                case 0:
                    currentColor = "Cyan";
                    sr.color = ColorPalette.Instance.colorCyan;
                    break;
                case 1:
                    currentColor = "Yellow";
                    sr.color = ColorPalette.Instance.colorYellow;
                    break;
                case 2:
                    currentColor = "Magenta";
                    sr.color = ColorPalette.Instance.colorMagenta;
                    break;
                case 3:
                    currentColor = "Pink";
                    sr.color = ColorPalette.Instance.colorPink;
                    break;
                
            }
        }
        
    }
    
}
