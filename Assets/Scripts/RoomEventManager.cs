using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomEventManager : MonoBehaviour
{
    public CountCapturer RoomCounter;
    int count ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count = RoomCounter.timesEntered;
        Events();
    }

    void Events()
    {
        if (count == 0)
        {

        }
        if (count == 8)
        {

        }
        if (count == 10)
        {

        }
        if (count == 20)
        {

        }
        if (count == 22)
        {

        }
        if (count == 24)
        {

        }
        if (count == 32)
        {

        }
        if (count == 34)
        {

        }
        if (count == 26)
        {

        }
        if (count == 38)
        {

        }
        if (count == 42)
        {

        }
        if (count == 44)
        {

        }
        if (count == 50)
        {

        }
        if (count == 52)
        {

        }
        if (count == 54)
        {

        }
        if (count == 58)
        {

        }
    }
}
