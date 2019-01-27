using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScriptSetActive : MonoBehaviour {

    public bool collides;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (collides == true && Input.GetKeyDown(KeyCode.E))
            gameObject.SetActive(false);/*ramane de adaugat cod pt activat canvasul cu dialog cand playerul intra in collision box,
                                          face o algere, si canvasul e dezactivat dupa + de dezactivat/distrus obiecte de pe mapa in functie de alegere*/
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            collides = true;
        }
    }
}
