using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Hello, I would like to write this comment for a grade.

        Debug.Log(transform.position.x);
        if(transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
