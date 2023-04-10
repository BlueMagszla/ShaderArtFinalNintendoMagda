using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Magdalena Szlapczynski 2023 Shader Art 501
//Code is to move camera around the scene to view the assets up close 

public class CameraControl : MonoBehaviour

{

    public float speed = 5.0f; //how fast camera moves
    public float sensitivity = 5.0f; //how sensitive mouse movement is for rotating camera

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Move camera around, forward, backward, left, right
        transform.position += transform.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.position += transform.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        //Rotate the camera based on the mouse movement
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        transform.eulerAngles += new Vector3(-mouseY * sensitivity, mouseX * sensitivity, 0);
    }
}