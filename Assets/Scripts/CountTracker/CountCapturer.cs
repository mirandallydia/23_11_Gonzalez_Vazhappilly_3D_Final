using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountCapturer : MonoBehaviour
{
    public int timesEntered;
    // Start is called before the first frame update
    void Start()
    {
        timesEntered = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            timesEntered = timesEntered + 1;
        }
    }
}
