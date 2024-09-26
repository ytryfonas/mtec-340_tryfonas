using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleBehavior : MonoBehaviour
{
    public float Speed = 5.0f;
    public float xLimit = 7.75f;

    public KeyCode LeftKey; 
    public KeyCode RightKey; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(RightKey) && transform.position.x < xLimit)
        {
            transform.position += new Vector3(x:Speed * Time.deltaTime, y:0 , z:0);
        }
       if(Input.GetKey(LeftKey) && transform.position.x > -xLimit)
        {
            transform.position -= new Vector3(x:Speed * Time.deltaTime, y:0, z:0);
        }
    }
}