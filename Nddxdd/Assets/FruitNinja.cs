using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitNinja : MonoBehaviour {
    
	// Use this for initialization
	void Start () {

        //we made fruit a public class, so we can create fruit from any scrripts from the project
        Fruit myFruit = new Fruit("Lemon", "sweet", "brown", 2);
        Apple myApple = new Apple();
        //these two chop functiosn will behave difernely 
        //the apple chop has been ID as a new function that will deviate from the parent
        myFruit.Chop();
        myApple.Chop();
        //this will downgrade my apple to be a fruit
        //this is called variable casting
        Fruit fakeApple = (Fruit)myApple;
        
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

public class Apple : Fruit {
    public bool inOnTree;

    public Apple() {
        inOnTree = true;
        Debug.Log("calling the apple construsctor");
    }

    //create a differnt chop function for the apple
    //this will overide the fruit chop
    public new void Chop() {
        Debug.Log("The " + color + " apple has been sliced and diced");
    }
}