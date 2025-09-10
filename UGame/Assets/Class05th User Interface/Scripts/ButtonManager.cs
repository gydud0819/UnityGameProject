using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] Button[] buttonList;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //[SerializeField] Text[] buttonName;
    [SerializeField] string[] buttonName = new string[] {"Start", "Option", "Quit"};
    Selectable selectable;
    void Start()                                         
    {                                                     
        //buttonName = GetComponentInChildren<Text>();

        Action[] actions = { Execute, Option, Quit };

        for (int i = 0; i < actions.Length; i++)
        {
            int index = i;      // ���� ĸ��,,, �޸�,,, 

            buttonList[i].GetComponentInChildren<Text>().text = buttonName[index];

            buttonList[i].onClick.AddListener(() => actions[index]());     // �����޴µ� ��¥ ���ٽ��̿���;;;;;;;;
        }


        //buttonName[0].text = "Start";
        //buttonName[1].text = "Option";
        //buttonName[2].text = "Quit";



    }

    public void Execute()
    {
       

        Debug.Log("Execute");
    }

    public void Option()
    {

        Debug.Log("Option");

    }

    public void Quit()
    {

        Debug.Log("Quit");

    }


}
