using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    int notifications;
    float miningSpeed;
    int bronzeSupply;
    int bronze;
    int silverSupply;
    int silver;

    // Start is called before the first frame update
    void Start()
    {
        miningSpeed = 3;
        bronzeSupply = 3;
        silverSupply = 2;
        bronze = 0;
        silver = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //If available, mine bronze
        if ((Time.time) >= miningSpeed && bronzeSupply > 0)
        {
            bronzeSupply--;
            bronze++;
            miningSpeed += 3; //Keeps miningSpeed in time with Time.time
            print("Time.time = " + (Time.time) + "\nYour bronze: " + bronze + " AND Your silver: " + silver);
        }

        //If availabe, mine silver
        else if ((Time.time) >= miningSpeed && silverSupply > 0)
        {
            silverSupply--;
            silver++;
            miningSpeed += 3;
            print("Time.time = " + (Time.time) + "\nYour bronze: " + bronze + " AND Your silver: " + silver + "\n Time.time = " + (Time.time));
        }

    }
}
