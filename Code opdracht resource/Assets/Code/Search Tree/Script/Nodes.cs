using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodes : MonoBehaviour
{
    public Node start;
    public string inputText;
    public int number;
    public bool bostart;
	
	void Start ()
    {

	}
	
	
	void Update ()
    {
        if (bostart)
        {
            AddNumber(number, inputText);
            bostart = false;
        }
    }

    public void AddNumber(int num, string text)
    {
        if(start == null)
        {
            start = new Node(num, text);
        }
        else if(start.number != num)
        {
            Node edon = start;
            bool done = false;
            while (!done)
            {
                if(num > edon.number)
                {
                    if (edon.higher != null)
                    {
                        edon = edon.higher;
                    }
                    else
                    {
                        edon.higher = new Node(num, text);
                        done = true;
                    }
                }
                else if(num < edon.number)
                {
                    if (edon.lower != null)
                    {
                        edon = edon.lower;
                    }
                    else
                    {
                        edon.lower = new Node(num, text);
                        done = true;
                    }
                }
                else
                {
                    Debug.Log(edon.text);
                    done = true;
                }
            }
        }
        else
        {
            Debug.Log(start.text);
        }
    }
}

public class Node
{
    public string text;
    public int number;
    public Node higher;
    public Node lower;

    public Node (int newNumber, string newText)
    {
        number = newNumber;
        text = newText;
    }
}
