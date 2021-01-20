using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovePcView : PlayerMoveView
{
    
 
    
    float x = 0f, y = 0f;

    

    void Start()
    {
        x = 0f;
        y = 0f;
        joestick = new Vector2(x, y);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {
            y= 1f;
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            y = -1f;
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            x = -1f;
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            x = 1;
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            x = 1;
        }

        if ( Input.GetKey(KeyCode.Q))
        {
            presenter.LeftDirectional = true;
        }

        if (Input.GetKey(KeyCode.E))
        {
            presenter.RightDirectional = true;
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            presenter.LeftDirectional = false;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            presenter.RightDirectional = false;
        }

        //----------------------Soltar

        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W))
        {
            y = 0f;
        }

        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
        {
            y = -1f;
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.A))
        {
            x = 0f;
        }

        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D))
        {
            x = 0f;
        }
        
        if (Input.GetKey(KeyCode.Space) )
        {
            presenter.Frenar = true;
        }
        if (Input.GetKeyUp(KeyCode.Space) )
        {
            presenter.Frenar = false;
        }

        if (Input.GetKey(KeyCode.P))
        {
            presenter.Cornet = true;
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            presenter.Cornet = false;
        }



        joestick = new Vector2(x, y);

        presenter.Joestick(joestick);
        

    }
}
