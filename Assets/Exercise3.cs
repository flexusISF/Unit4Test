using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    public float RandomPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            // Uncomment the line below after you write the method
           //transform.position = RandomPosition();
        }
    }

    /****************************************
     * Create a RandomPosition() Method that will return a Vector2.
     * Generate a random xPos between -5 and 5
     * Generate a radom yPos between  0 and 4
     * Create a new Vector2 called randomPos that uses xPos and yPos
     * return randomPos
     * 
     * **************************************/
    public Vector2 RandomPosition(Vector2
    {
        float xPos = Random.Range(-5, 5);
        float yPos = Random.Range(0, 4);
        Vector2 Random Pos = new Vector2(xPos, yPos);
        return Random Pos;
    }

}
