using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Sensitivity : MonoBehaviour
{
    public float sens = 5;
    public Transform orientation;

    public float xRotation;
    public float yRotation;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += sens * new Vector3(-Input.GetAxisRaw("Mouse Y"), Input.GetAxisRaw("Mouse X"), 0);


    }
}
