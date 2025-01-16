using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace Assignment29
{
    public class BasicsScript : MonoBehaviour
    {
        void Start()
        {
            //part 1 run
            var num = UnityEngine.Random.Range(1, 100);
            var isEven = num % 2 == 0;
            var name = isEven ? "even" : "odd";
            Debug.Log($"The number {num} is {name}.");
            Debug.Log(DateTime.Now.Date);
            Debug.Log(DateTime.Now.TimeOfDay);
            Debug.Log(DateTime.Now.DayOfWeek);
        }

    }
    public class CustomObject
    {
        int _id;
        string _name;
        public int ID
        {
            set => _id = value;
            get => _id;
        }
        public string Name
        {
            set => _name = value;
            get => _name;
        }
        public CustomObject(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public override string ToString() => $"Object [ID: {ID}, Name: {Name}]";
        public override bool Equals(object obj)
        {
            if (obj != null && obj is CustomObject)
            {
                var theOtherObject = obj as CustomObject;
                return this.ID == theOtherObject.ID && this.Name == theOtherObject.Name;
            }
            else return false;
        }
        public static bool operator ==(CustomObject obj1, CustomObject obj2)
        {
            //if both are null then they are equal
            if (obj1 is null && obj2 is null) return true;
            //if one of them is null then they are not equal
            else if (obj1 is null ^ obj2 is null) return false;
            return obj1.Equals(obj2);
        }
        //using the negation of the == operator method
        public static bool operator !=(CustomObject obj1, CustomObject obj2) => !(obj1 == obj2);
    }

    public static class Utilities
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers) sum += num;
            return sum;
        }
        public static string RepeatString(this string str, int times)
        {
            string res = "";
            for (int i = 0; i < times; i++) res += str;
            return res;
        }
    }

}
