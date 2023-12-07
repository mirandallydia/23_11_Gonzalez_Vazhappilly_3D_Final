using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventResponder : MonoBehaviour
{
    //list of transform moves
    [SerializeField] float[] transformX, transformY;
    float currentPosX, currentPosY;
    //list of mesh changes
    [SerializeField] Material[] material;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TransformChangeOne()
    {
        gameObject.transform.position = new Vector3(transformX[1], transformY[1]);

    }

    public void MeshChangeOne()
    {
        gameObject.GetComponent<MeshRenderer>().material = material[1];
    }

    public void TransformChangeTwo()
    {
        gameObject.transform.position = new Vector3(transformX[2], transformY[2]);
    }

    public void MeshChangeTwo()
    {
        gameObject.GetComponent<MeshRenderer>().material = material[2];
    }

    public void TransformChangeThree()
    {
        gameObject.transform.position = new Vector3(transformX[3], transformY[3]);
    }

    public void MeshChangeThree()
    {
        gameObject.GetComponent<MeshRenderer>().material = material[3];
    }
}
