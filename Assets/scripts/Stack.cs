using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stack : MonoBehaviour
{
    // public InputField input;
    

    private Stack<string> planner = new Stack<string>();
    public Text display;
    public Text result;
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        display.text = "what did you do today?\n \n a: sleep   b: watch movie  c: work out     d: playing games    e: homeworks \n f: exit";
        
        

        if (Input.GetKeyDown(KeyCode.A))
        {
            planner.Push("sleep");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            planner.Push("watch movie");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            planner.Push("work out");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            planner.Push("playing games");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            planner.Push("home work");
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            result.text += "\n" + planner.Pop();
        }
    }

}
