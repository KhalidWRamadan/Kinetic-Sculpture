using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class UnitySpecificScript : MonoBehaviour
    {
        GameObject target;

        //part 6
        void OnEnable()
        {
            print("GameObject Enabled");
        }
        void Start()
        {
            print("Game started!");
            target = GameObject.Find("TargetObject");
            if (target != null) print($"Found object by name: {target.name}");
            else print("No TargetObject found.");

            GameObject joker = GameObject.FindGameObjectWithTag("Joker");
            if (joker != null) print($"Found object by tag: {joker.name}");
            else print("No Joker object found.");

            Light light = FindObjectOfType<Light>();
            if (joker != null) print($"Found object of type Light: {light.name}");
            else print("No Light object found.");


        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                target.SetActive(false);
                print("TargetObject deactivated!");
            }
        }
        void OnDisable()
        {
            print("GameObject Disabled");
        }
    }
}
