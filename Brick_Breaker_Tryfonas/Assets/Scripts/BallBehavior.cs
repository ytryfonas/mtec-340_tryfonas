using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public float Speed = 3.0f;

    public float yLimit = 4.75f;

    public float xLimit = 10;
    private Vector2 _direction; 


    // Start is called before the first frame update
    void Start()
    {
        ResetBall();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(
            x:Speed * _direction.x,
            y:Speed * _direction.y,
            z:0.0f
        ) * Time.deltaTime;

        if (Mathf.Abs(transform.position.y) >= yLimit)
        {
            _direction *= -1;
        }

        if (Mathf.Abs(transform.position.x) >= xLimit)
        {
            transform.position = Vector3.zero;

            ResetBall();
            ;
        }
    }
    void ResetBall()
    {
        transform.position = Vector3.zero;

        _direction = new Vector2(
            // Turnary operator
            // condition ? passing : failing
            Random.value > 0.5f ? 1 : -1, 
            Random.value > 0.5f ? 1 : -1 
        );
    }
}