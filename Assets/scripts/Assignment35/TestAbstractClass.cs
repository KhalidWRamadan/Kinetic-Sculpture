using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class TestAbstractClass : MonoBehaviour
    {
        DerivedClassExample derivedClassExample = new DerivedClassExample();
        void Start()
        {
            derivedClassExample.PerformAction();
            derivedClassExample.PrintInfo();

        }
    }
}
