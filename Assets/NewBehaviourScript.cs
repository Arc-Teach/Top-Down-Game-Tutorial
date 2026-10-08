using UnityEngine;
//  Classes are a type of object in our game.
//  They have methods which are things can do.
public class NewBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //  This a comment! Comments are text in our code that doesn't run
    //  They are used to explain our code to other developers
   void Start()
    {
        Debug.Log("Hello, world!");
    }

    // Update is called once per frame
    void Update()
    {
        //Methods are things that the code does
        //Called functions in other languages
        transform.position += new Vector3(1,0,0);

        //Classes are the type of thing
        //Each individual is an Object
        //Class: Library Table
        //Object: Each table in the library
        //Methods are the things objects do
        //In Unity, every object has Start and Update
        //Start runs once at the beginning
        //Update runs once per frame
    }


    void FixedUpdate()
    {
    }
}
