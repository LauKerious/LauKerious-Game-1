using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    private Transform Player;
    private float Vertical;
    private float Horizontal;
    [SerializeField] private float Movespeed = 8f;
    private float Diagonalspeed = 0.7f;

    // Start is called before the first frame update
    void Start()
    {
        Player = this.transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        input();  
    }

    private void input()
    {
        Vertical = Input.GetAxis("Vertical");
        Horizontal = Input.GetAxis("Horizontal");

    }
    private void Movespeeed()
    {
        float Horizontalspeed = Horizontal * Movespeed;
        float Verticalspeed = Vertical * Movespeed;
                    

        if (Horizontal != 0 && Vertical != 0)
        {
            Player.position = new Vector2(Horizontalspeed * Diagonalspeed * Time.deltaTime, Verticalspeed * Diagonalspeed * Time.deltaTime);
            
         }

    }
}
