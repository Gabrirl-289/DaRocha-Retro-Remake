using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //this is a integer, its a variable, privates veriables is not shown on components. ints is for whole numbers
    public int CoinCount;

    //floats is for DECIMAL numbers
    public float xposition;

    //strings represents words or phrases
    public string StudentName;

    //BOOL represent true or false variable
    public bool enemyIsDead;

    //vectors 2 represents a 2-dimensional number
    public Vector2 ffCorpesLoc;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(" dereck fav student is" + StudentName);

        if (enemyIsDead) // only run the below code if ENEMYISDEAD is corrently true
        {
            Debug.Log("good ridance");
        }
        else // only runs the code if the if statement does not execute
        {
            Debug.Log("Heebie jeebies");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
