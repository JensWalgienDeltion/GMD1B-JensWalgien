using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conversation : MonoBehaviour
{
    public GameObject panel;
    public GameObject code;
    public Text questText;
    public Text answer1Text;
    public Text answer2Text;
    public List<string> questions = new List<string>();
    public List<string> answers1 = new List<string>();
    public List<string> answers2 = new List<string>();
    public int questInt;
    public int answer1Int;
    public int answer2Int;
    public bool answer1Bool;
    public bool answer2Bool;

    void Start()
    {
        


    }

    void Update()
    {
        questText.text = questions[questInt].ToString();
        answer1Text.text = answers1[answer1Int].ToString();
        answer2Text.text = answers2[answer2Int].ToString();
    }


    public void Answer1()
    {
        answer1Bool = true;
        if(answer1Bool == true)
        {
            answer1Int = (answer1Int * 2);
            answer2Int = (answer2Int * 2);
            questInt = (questInt * 2);
            print("Answer1");
            Endconversation();
            answer1Bool = false;
        }
    }

    public void Answer2()
    {
        answer2Bool = true;
        if(answer2Bool == true)
        {
            answer1Int = (answer1Int * 2) + 1;
            answer2Int = (answer2Int * 2) + 1;
            questInt = (questInt * 2) + 1;
            print("Answer2");
            Endconversation();
            answer2Bool = false;
        }
    }

    public void Endconversation()
    {
        if (questions.Count <= questInt)
        {
            panel.SetActive(false);
            code.SetActive(false);
        }
    }
}
