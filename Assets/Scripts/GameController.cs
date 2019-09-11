using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    int notifications = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((Time.time) >= 3 && notifications == 0)
        {
            print((Time.time) + " It's been three seconds!");
            notifications++;
        }

    }
}
