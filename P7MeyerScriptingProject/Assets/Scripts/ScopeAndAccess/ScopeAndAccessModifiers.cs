using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifiers : MonoBehaviour
{
    //Public variable that can be accessed by other scripts
    public int alpha = 5;

    //2 Private scripts only accessible by this script
    private int beta = 0;
    private int gamma = 5;

    //A method that can be accessed by other scripts

    private AnotherClass myOtherClass;

    // Start is called before the first frame update
    void Start()
    {
        alpha = 2328;

            myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);

    }
    void Example(int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}
