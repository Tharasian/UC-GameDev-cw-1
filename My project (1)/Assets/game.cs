using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{
    int heroAge = 23;
    string heroSuperPower = "Rasengan";
    float heroHeight = 176.4f;
    string heroName = "Naruto";

    string villianName = "Sasuke";
    int villianAge = 20;
    string villianSuperPower = "Chidori";
    float villianHeight = 180f;
    
    // Start is called before the first frame update
    void Start()
    {
        villianSuperPower = "none";
        heroHeight = heroHeight+5f;

        print("I am " + heroName + " and I my ability is called " + heroSuperPower);
        print("I am " + heroAge + " years old and i am " + heroHeight + "cm tall!");
        print(villianName + " is my nemesis!");
        print("\n I am " + villianName + " I am " + villianHeight + "cm tall and " + villianAge + " years old");
        print("I will destroy " + heroName + " with my " + villianSuperPower + " super power!");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
