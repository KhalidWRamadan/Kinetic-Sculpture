using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35
{
    public class ListMethodsExample : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9 };
            numbers.Sort((x, y) => y.CompareTo(x));
            print(string.Join(", ", numbers));

            List<int> numbers2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
            List<int> filteredNumbers = numbers2.FindAll(num => num % 2 == 0);
            print(string.Join(", ", filteredNumbers));
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
