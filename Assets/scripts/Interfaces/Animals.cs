using UnityEngine;


namespace Assignment26
{
    public class Kangaroo : Creature, IRunnable, IJumpable
    {
        public void Jump()
        {
            Debug.Log("Kangaroo jumps.");
        }

        public void Run()
        {
            Debug.Log("Kangaroo runs.");
        }
        public override void Speak()
        {
            Debug.Log("Kangaroo says: Hop!");
        }
    }
    public class Duck : Creature, IRunnable, ISwimmable
    {

        public void Swim()
        {
            Debug.Log("Duck swims.");
        }

        public void Run()
        {
            Debug.Log("Duck runs.");
        }
        public override void Speak()
        {
            Debug.Log("Duck says: Quack!");
        }

    }
}