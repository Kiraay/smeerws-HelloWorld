//smeerws: 
//printing messages to the unity console

using System;
using UnityEngine;

public class HelloWorld : MonoBehaviour // Use this for initialization
{

    void Start ()
    {
        string HelloWorldText = "Hello World (hw)";
        print("(print) Hello World");
        Debug.Log("(Debug.Log) Hello World");
        Console.WriteLine("(Console.WriteLine) Hello World"); //Console.WriteLine does nothing inside the Unity Engine,
                                                              //because Unity uses a custom console, only accessed 
        print("(print - HelloWorldText) " + HelloWorldText);
        Debug.Log("(Debug.Log - HelloWorldText ) " + HelloWorldText);                 //through Unity Engine: Debug.Log, ...
        Console.WriteLine("Console.WriteLine - HelloWorldText" + HelloWorldText);     //Unity doesn't display the standard C# Console.
    }
}
