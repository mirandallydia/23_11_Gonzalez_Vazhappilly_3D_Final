using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickupDrop : MonoBehaviour
{
   private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Physics.Raycast();
        }
    }
}
