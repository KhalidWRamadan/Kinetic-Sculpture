using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class RecursionScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            print(FibonacciR(13));
            print(FibonacciI(13));
        }

        int FibonacciR(int n)
        {
            if (n <= 1) return n;
            else return FibonacciR(n - 1) + FibonacciR(n - 2);
        }
        int FibonacciI(int n)
        {
            if (n <= 1) return n;
            int first = 0, second = 1;

            for (int i = 1; i < n; i++)
            {
                int iFib = first + second;
                first = second;
                second = iFib;
            }
            return second;
        }
    }
}
