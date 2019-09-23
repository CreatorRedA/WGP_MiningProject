using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float miningSpeed;
    int bronzeSupply;
    int bronze;
    int silverSupply;
    int silver;

    //public makes the variable available to other scripts and visible in editor
    public GameObject bronzeCubePrefab;
    public GameObject silverCubePrefab;
    int xPos = 0;

    void CreateCube(Vector3 cubePosition, GameObject cubePrefab) //Function CreateCube accepts a Vector3 called cubePosition and a GameObject called cubePrefab
    {
        Instantiate(cubePrefab, cubePosition, Quaternion.identity); //Create cube
        xPos += 2;
        miningSpeed += 3; //Keeps miningSpeed in time with Time.time
        print("Time.time = " + (Time.time) + "\nYour bronze: " + bronze + " AND Your silver: " + silver);
    }

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
            CreateCube(new Vector3(xPos, 0, 0), bronzeCubePrefab);
        }

        //If availabe, mine silver
        else if ((Time.time) >= miningSpeed && silverSupply > 0)
        {
            silverSupply--;
            silver++;
            CreateCube(new Vector3(xPos, -2, 0), silverCubePrefab);
        }

    }
}
