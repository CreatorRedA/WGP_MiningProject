using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public int oreType; //Tracks ore for the GameController

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Destroy(gameObject); //Destroys the gameObject this script is attached to (cube prefabs)
        if (oreType == 1)
        {
            GameController.bronzeSupply--;
            GameController.bronzeScore++;
            print("Bronze Pts: " + GameController.bronzeScore + " Silver Pts: " + GameController.silverScore + "Gold Pts: " + GameController.goldScore);
        }

        else if (oreType == 2)
        {
            GameController.silverSupply--;
            GameController.silverScore += 10;
            print("Bronze Pts: " + GameController.bronzeScore + " Silver Pts: " + GameController.silverScore + "Gold Pts: " + GameController.goldScore);
        }

        else if(oreType == 3)
        {
            GameController.goldSupply--;
            GameController.goldScore += 100;
            print("Bronze Pts: " + GameController.bronzeScore + " Silver Pts: " + GameController.silverScore + "Gold Pts: " + GameController.goldScore);
        }
    }
}
