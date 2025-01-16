using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class TypeManagmentScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            //part 4
            Animal cat = new Cat();
            cat.MakeSound();
            cat.Move();

            Cat castedCat = cat as Cat;
            castedCat.MakeSound();
            castedCat.Move();

            List<ICanFight> fighters = new List<ICanFight>() { new Cat(), new Warrior() };
            foreach (var fighter in fighters)
            {
                fighter.attack();
                if (fighter is Warrior) Debug.Log("The object is a Warrior.");
                else Debug.Log("The object is a Cat.");
            }


            //part 5
            int playerScore = 100;
            int diviser = 0;
            try
            {
                Debug.Log("Attempting to calculate score multiplier...");
                int totalScore = playerScore / diviser;
            }
            catch (DivideByZeroException)
            {
                Debug.Log("Error: Division by zero occurred while calculating score multiplier.");
            }
            finally
            {
                Debug.Log("Score calculation complete. Cleaning up resources.");
            }



        }

    }
    public class Animal
    {
        public virtual void MakeSound()
        {
            Debug.Log("Animal Sound");
        }
        public void Move()
        {
            Debug.Log("Animal Move");
        }
    }
    public class Cat : Animal, ICanFight
    {
        public void attack()
        {
            Debug.Log("Cat attacks with claws!");
        }

        public override void MakeSound()
        {
            Debug.Log("Meow!");
        }
        public void Move()
        {
            Debug.Log("Cat runs quickly.");
        }
    }
    public class Warrior : ICanFight
    {
        public void attack()
        {
            Debug.Log("Warrior attacks with a sword!");
        }
    }
    public interface ICanFight
    {
        public void attack();
    }
}
