
using UnityEngine;

namespace NameSpaceDemo
{
    [System.Serializable]
    public class MyNameClass
    {

        public string name;
        public int playerSpeed;
        public float playerRotation;
        public bool isAlive;
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
