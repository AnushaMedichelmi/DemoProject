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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
