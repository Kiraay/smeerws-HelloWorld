//smeerws: 
//printing messages to the unity console
using System;
using UnityEngine;
public class HelloWorld : MonoBehaviour // Use this for initialization
{
    void Start ()
    {
        string hw = "Hello World (hw)";
        print("(print) Hello World");
        Debug.Log("(Debug.Log) Hello World");
        Console.WriteLine("(Console.WriteLine) Hello World"); //Console.WriteLine does nothing inside the Unity Engine,
                                                              //because Unity uses a custom console, only accessed 
        print("(print - hw) " + hw);
        Debug.Log("(Debug.Log - hw ) " + hw);                 //through Unity Engine: Debug.Log, ...
        Console.WriteLine("Console.WriteLine - hw" + hw);     //Unity doesn't display the standard C# Console.
    }
    void Update () // Update is called once per frame
    {
    }
}
