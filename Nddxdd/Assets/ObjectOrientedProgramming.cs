using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOrientedProgramming : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//We create a new Fruit object and set its values:
		Fruit myFruit = new Fruit ();
		myFruit.taste = "sour";
		myFruit.color = "green";
		myFruit.name = "GreenSourFruit";
		myFruit.size = 12;
		//We can use our Fruit Object in the same way we can use any other variable.
		List<Fruit> fruitSalad = new List<Fruit> ();
		Fruit fruit2 = new Fruit ("Orange", "tangy", "pink", 20);
		Fruit fruit3 = new Fruit ();
        myFruit.Chop();
	}
}

//We define the fruit object and all its properties:
public class Fruit {
	public string name;
	public string taste;
	public string color;
	public int size;
	//this is the fruit constructor function that receives new values for the fruit variables:
	public Fruit(string newName, string newTaste, string newColor, int newSize) {
		name = newName;
		taste = newTaste;
		color = newColor;
		size = newSize;
	}
	public Fruit() {
        Debug.Log("calling the fruit construsctor");

    }

    public void Chop() {
        Debug.Log("The " + color + " " + name + " fruit has been chopped.");
    }

}
