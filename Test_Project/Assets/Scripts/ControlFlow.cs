using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool flag;
    
    // Start is called before the first frame update
    void Start()
    {
        if (flag)
        {
            Debug.Log("Boolean flag is set");
        }
        else
        {
            Debug.Log("Boolean flag isn’t set");
        }

        for (int i = 1; i <= 10; i++)
        {
            int powerOfTwo = (int)Mathf.Pow(2, i);
            Debug.Log($"The {i} power of 2 is {powerOfTwo}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
