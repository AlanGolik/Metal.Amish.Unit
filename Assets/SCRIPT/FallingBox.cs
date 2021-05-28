using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingBox : MonoBehaviour
{
    private float speed = 15f;
    public Rigidbody2D Rocket;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("PociskSpawner", 1.0f, 2f);
    }

    // Update is called once per frame
    void PociskSpawner()
    {
        int numBox = 5;
        int maxBox = 0;
         for (int i = 0; i < numBox; i++)
        {
           int chanse;
           chanse = Random.Range(0, 2);
            if(chanse==0 && maxBox < 2)
            {
                Rigidbody2D instance = Instantiate(Rocket, transform);
                instance.velocity = Vector2.down * speed;
                instance.transform.position = instance.transform.position + Vector3.right * i;

                maxBox += 1;
            }    
        }    
    }
}
