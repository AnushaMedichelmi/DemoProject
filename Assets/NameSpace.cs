using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NameSpaceDemo;
using NameSpaceDemo.MyUI;

//namespace is a keyword where we use before namespace
//syntax:namespace name {}
public class NameSpace : MonoBehaviour
{

    public MyNameClass MyDemoClass=new MyNameClass();
    // Start is called before the first frame update
    void Start()
    {
        NameSpaceDemo.MyNameClass.MyPrint();
        MyUI.MyPrintUI();
        Debug.Log(MyDemoClass.name);
        Debug.Log(MyDemoClass.playerSpeed);
        Debug.Log(MyDemoClass.playerRotation);
        Debug.Log(MyDemoClass.isAlive);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
