using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class buttonstarter : MonoBehaviour
{ 

    public GameObject TextBox;
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject Choice03;
    public int ChoiceMade;

public void ChoiceOption1()
{
    TextBox.GetComponent<Text>().text = "blahblahblah " ;
    ChoiceMade = 1;

}
public void ChoiceOption2()
{
    TextBox.GetComponent<Text>().text = "Choice Option1 2 " ;
    ChoiceMade = 2;

}
public void ChoiceOption3()
{
    TextBox.GetComponent<Text>().text = "Choice Option1 3 " ;
    ChoiceMade = 3;

}




  
    void Update()
    {
        if ( ChoiceMade>= 1)
        {
            Choice01.SetActive(false);
            Choice02.SetActive(false);
            Choice03.SetActive(false);
        }
    }
}

