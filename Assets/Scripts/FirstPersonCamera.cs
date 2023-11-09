using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{

    // DRAG CAMERA TO BE CHILD OF PLAYER, ADD IN PLAYER INSPECTOR, RESET CAMERA POSITION AND ADJUST

    public Transform playerCamera;
    public Vector2 mouseSensitivity = new Vector2(9f, 9f);
    private float rotationV;
    public float minimumV = -45f;
    public float maximumV = 45f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null) 
        {
            rb.freezeRotation = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * mouseSensitivity.x, 0);

        rotationV -= Input.GetAxis("Mouse Y") * mouseSensitivity.y;
        rotationV = Mathf.Clamp(rotationV, minimumV, maximumV);
        playerCamera.localEulerAngles = new Vector3(rotationV, 0, 0);
    }
}
