using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int myInt = 9;
    // Start is called before the first frame update
    void Start()
    {
        myInt = MultiplyByTwo(myInt+1);
        Debug.Log(myInt);
    }
    int MultiplyByTwo (int number)
    {
        int result;
        result = number * 2;
        return result;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}