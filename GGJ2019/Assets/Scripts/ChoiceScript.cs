using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceScript : MonoBehaviour {

    public GameObject TextBox;
    public GameObject Choice01;
    public GameObject Choice02;
    public int ChoiceMade;

    public void ChoiceOption1()
    {
        TextBox.GetComponent<Text>().text = "Nevasta, AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA - o sa mori de gura ei";
        ChoiceMade = 1;
    }

    public void ChoiceOption2()
    {
        TextBox.GetComponent<Text>().text = "Iti plac copiii...";
        ChoiceMade = 2;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(ChoiceMade >= 1)
        {
            Choice01.SetActive(false);
            Choice02.SetActive(false);
        }
	}
}
