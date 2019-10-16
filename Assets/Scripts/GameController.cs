using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float miningSpeed;
    public static int bronzeSupply; //Static prevents Unity from making copies of this variable (prefab replicas)
    public static int silverSupply;
    public static int goldSupply;
    public static int bronzeScore;
    public static int silverScore;
    public static int goldScore;

    //public makes the variable available to other scripts and visible in editor
    public GameObject bronzeCubePrefab;
    public GameObject silverCubePrefab;
    public GameObject goldCubePrefab;
    GameObject myCube;
    int xPos = -10;
    int rowCount = 0;

    void CreateCube(GameObject cubePrefab, Vector3 cubePosition, int ore) //Function CreateCube accepts a Vector3 called cubePosition and a GameObject called cubePrefab
    {
        myCube = Instantiate(cubePrefab, cubePosition, Quaternion.identity); //Create cube
        myCube.GetComponent<CubeController>().oreType = ore; //Set oreType inside CubeController script on myCube that we just instantiated
        miningSpeed += 2; //Keeps miningSpeed in time with Time.time
        print("Time.time = " + (Time.time) + "\nBronze supply: " + bronzeSupply + " Silver supply: " + silverSupply + " Gold supply: " + goldSupply + " xPos = " + xPos);
        xPos += 2;

        //Resets rows by 4 (unless cubes are mined at uneven pace)
        rowCount++;
        if(rowCount == 4)
        {
            xPos = -10;
            rowCount = 0;
        }
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
            CreateCube(goldCubePrefab, new Vector3(xPos, 0, 0), 3);
            goldSupply++;
        }

        else if ((Time.time) >= miningSpeed && bronzeSupply >= 4)
        {
            CreateCube(silverCubePrefab, new Vector3(xPos, 2, 0), 2);
            silverSupply++;
        }

        else if ((Time.time) >= miningSpeed && bronzeSupply < 4)
        {
            CreateCube(bronzeCubePrefab, new Vector3(xPos, 4, 0), 1);
            bronzeSupply++;
        }
    }
}
