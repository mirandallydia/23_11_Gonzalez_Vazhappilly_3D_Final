using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventResponder : MonoBehaviour
{
    //list of transform moves
    [SerializeField] float[] transformX, transformY,transformZ;
    [SerializeField] float[] rotX, rotY;
    float z;
    //list of mesh changes
    [SerializeField] Material[] material;

    // Start is called before the first frame update
    void Start()
    {
        transformX[1] = transform.position.x;
        transformY[1] = transform.position.y;
        transformZ[1] = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TransformChangeOne()
    {
        float z = gameObject.transform.rotation.z;
        gameObject.transform.position = new Vector3(transformX[0], transformY[0], transformZ[0]);
        gameObject.transform.rotation = Quaternion.Euler(rotX[1], rotY[1], z);

    }

    public void MeshChangeOne()
    {
        gameObject.GetComponent<MeshRenderer>().material = material[0];
    }

    public void TransformChangeTwo()
    {
        float z = gameObject.transform.rotation.z;
        gameObject.transform.position = new Vector3(transformX[1], transformY[1], transformZ[1]);
    }

    public void MeshChangeTwo()
    {
        gameObject.GetComponent<MeshRenderer>().material = material[1];
    }

    public void TransformChangeThree()
    {
        gameObject.transform.position = new Vector3(transformX[2], transformY[2], transformZ[2]);
    }

    public void MeshChangeThree()
    {
        gameObject.GetComponent<MeshRenderer>().material = material[2];
    }
    public void TransformChangeFour()
    {
        gameObject.transform.position = new Vector3(transformX[3], transformY[3], transformZ[3]);
    }

    public void MeshChangeFour()
    {
        gameObject.GetComponent<MeshRenderer>().material = material[3];
    }
}
