using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class BoxingUnboxing : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int health = 100;
            object obj = health;
            int myHealth = (int)obj + 20;

            print(health);
            print(obj);
            print(myHealth);
        }


    }
}
