using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float miningSpeed;
    int bronzeSupply;
    int bronzeScore;
    int silverSupply;
    int silverScore;
    int goldSupply;
    int goldScore;

    //public makes the variable available to other scripts and visible in editor
    public GameObject bronzeCubePrefab;
    public GameObject silverCubePrefab;
    public GameObject goldCubePrefab;
    int xPos = 0;

    void CreateCube(Vector3 cubePosition, GameObject cubePrefab) //Function CreateCube accepts a Vector3 called cubePosition and a GameObject called cubePrefab
    {
        Instantiate(cubePrefab, cubePosition, Quaternion.identity); //Create cube
        xPos += 2;
        miningSpeed += 3; //Keeps miningSpeed in time with Time.time
        print("Time.time = " + (Time.time) + "\nBronze supply: " + bronzeSupply + " Silver supply: " + silverSupply + " Gold supply: " + goldSupply);
    }

    // Start is called before the first frame update
    void Start()
    {
        miningSpeed = 3;
        bronzeSupply = 0;
        silverSupply = 0;
        goldSupply = 0;

        bronzeScore = 0;
        silverScore = 0;
        goldScore = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if ((Time.time) >= miningSpeed && bronzeSupply == 2 && silverSupply == 2)
        {
            goldSupply++;
            CreateCube(new Vector3(xPos, -4, 0), goldCubePrefab);
        }

        else if ((Time.time) >= miningSpeed && bronzeSupply >= 4)
        {
            silverSupply++;
            CreateCube(new Vector3(xPos, -2, 0), silverCubePrefab);
        }

        else if ((Time.time) >= miningSpeed && bronzeSupply < 4)
        {
            bronzeSupply++;
            CreateCube(new Vector3(xPos, 0, 0), bronzeCubePrefab);
        }


    }
}
