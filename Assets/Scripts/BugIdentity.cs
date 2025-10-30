using System;
using System.Linq;
using UnityEngine;

//store bug identity information

public class BugIdentity : MonoBehaviour
{
    public string bugName;
    public string description;
    public string[] children;
    [SerializeField] public string nature;


    void Start()
    {

    }
    public string GetDescription()
    {
        // basic for now, could make nicer/separate functions for formatting
        return $"{bugName}\n\n" +
               $"{description}\n";
    }

}
