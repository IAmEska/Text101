using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    private enum States { Cell, Mirror, Sheets_0, Lock_0, Sheets_1, Lock_1, Freedom };
    private States myState;

    public Text text;


	// Use this for initialization
	void Start () {
        myState = States.Cell;
	}
	
	// Update is called once per frame
	void Update () {

        switch(myState)
        {
            case States.Cell:
                StateCell();
                break;

            case States.Sheets_0:
                StateSheets0();
                break;

            case States.Sheets_1:
                StateSheets1();
                break;

            case States.Lock_0:
                StateLock0();
                break;

            case States.Lock_1:
                StateLock1();
                break;
                
        }
    
	}

    void StateCell()
    {
        text.text = "You are in a prison cell, and you want to escape. There are " +
                "some dirty sheets on the bed, a mirror on the wall, and the door " +
                "is locked from the outside.\n\n" +
                "Press S to view sheets\n" +
                "Press M to view mirror\n" +
                "Press L to view lock";

        if(Input.GetKeyDown(KeyCode.S))
        {
            myState = States.Sheets_0;   
        }

    }

    void StateSheets0()
    {
        text.text = "You can´t believe you sleep in these things. Surely it´s " +
                "time somebody changed them. The pleasures of prison life I guess!\n\n" +
                "Press R to return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.Cell;
        }
    }

    void StateLock0()
    {
        text.text = "This is one of those button locks. You have no idea what the combination is. " +
            "You wish you could somehow see where the dirty fingerprints were, maybe that would help.\n\n" +
            "Press R to return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.Cell;
        }
    }

    void StateSheets1()
    {

    }
    

    void StateLock1()
    {

    }
}
