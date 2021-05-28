using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContlroller : MonoBehaviour
{
    public float speed = 10000f;
    private Vector3 velocity;


    // Start is called before the first frame update
    void Start()
    {
        velocity = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, velocity, speed * Time.deltaTime);
        //print(velocity);
    }

    public void MoveLeft()
    { 
    if (velocity.x > -5.10)
        {
            velocity += Vector3.left;
        }    
    }
    public void MoveRight()
    {
    if (velocity.x < -0.45)
        {
            velocity += Vector3.right;
        }
    }


}
