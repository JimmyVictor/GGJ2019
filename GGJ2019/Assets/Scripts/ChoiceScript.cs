using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceScript : MonoBehaviour
{

    public bool collides;
    //public Canvas canvas;
    
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
    void Update()
    {
        if (ChoiceMade >= 1)
        {
            Choice01.SetActive(false);
            Choice02.SetActive(false);
        }
        if (collides == true && Input.GetKeyDown(KeyCode.E))
        {
            /*canvas = GameObject.FindGameObjectWithTag("Canvas1").GetComponent<Canvas>();
            canvas.SetActive(false);*/
            GameObject.FindGameObjectWithTag("Canvas1").SetActive(false);/*de lasat canvasul transparent pe ecran pe parcursul intregului joc si de schimbat textul doar...?
            ramane de adaugat cod pt activat canvasul cu dialog cand playerul intra in collision box, face o algere, si canvasul e dezactivat dupa + de dezactivat/distrus obiecte
            de pe mapa in functie de alegere*/
                                          
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            collides = true;
        }
    }
}
