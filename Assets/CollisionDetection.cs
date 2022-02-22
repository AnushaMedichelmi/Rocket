using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {


        /*if (collision.gameObject.tag == "RocketAllowed")
        {
            Debug.Log("You are allowed");
        }
        else if (collision.gameObject.tag == "NotAllowed")
        {
            Debug.Log("You are not allowed");
        }*/


        /* private void OnCollisionEnter2D(Collision2D collision)
         {
             if(collision.gameObject.name =="Wall")
             {
                 Debug.Log("You collided with the wall and lost");
             }
         }*/

        Debug.Log("you won the game");
    }


    
}
