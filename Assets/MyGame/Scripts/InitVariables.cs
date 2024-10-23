using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitVariables : MonoBehaviour
{
    [SerializeField] int[] test = { 10, 20, 30, 40 };
    [SerializeField] int[] test2;
    private int[] test3;
    public int initVariableTest1 = 0;
    [SerializeField] int initVariableTest2 = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        test3 = new int[4];
        Debug.Log(test2.Length);
        if(test3 == null)
        {
            Debug.Log("test 3 is null");
            
        }
        else
        {
            Debug.Log("test 3 is not null");
        }
        test2 = new int[] { 10, 20, 30, 40 };
        test = new int[]{ 10, 20, 30, 40 };
        Debug.Log("var 1 " + initVariableTest1);
        Debug.Log("var 2 " + initVariableTest2);

        TestMethod();
    }

    void TestMethod()
    {
        int[] nor; 
        nor = new int[]{ 3,3,3,3};
        Debug.Log("in Nor " + nor.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
