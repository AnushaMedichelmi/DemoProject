
using UnityEngine;

namespace NameSpaceDemo
{
    public class MyNameClass
    {
        public static void MyPrint()
        {
            Debug.Log("My Print Method from name sapce");
        }
    }

    namespace MyUI
    {
        public class MyUI
        {
            public static void MyPrintUI()
            {
                Debug.Log("My UI Method");
            }
        }
    }
}
