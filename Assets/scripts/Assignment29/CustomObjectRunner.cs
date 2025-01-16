using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class CustomObjectRunner : MonoBehaviour
    {

        void Start()
        {
            //part 2 run
            CustomObject obj1 = new CustomObject(100, "Khalid");
            CustomObject obj2 = new CustomObject(200, "Subhi");
            CustomObject obj3 = new CustomObject(100, "Khalid");

            print(obj1);
            print(obj1.Equals(obj2));
            print(obj1 == obj3);
            print(obj2 == obj3);

            print("-----------------");

            //part 3 run
            print(Utilities.Add(1, 5, 3, 6));
            print("Subhi".RepeatString(4));
        }

    }
}
