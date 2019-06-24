using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mOVING : MonoBehaviour
{
    public float yaw;
    public float pitch;
    public float xSpeed = 1;
    public float walkSpeed = 1;
    public float runSpeed = 2;
    public Transform miObj;
    // Start is called before the first frame update
    void Start()
    {
        miObj = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        yaw += xSpeed * Input.GetAxis("Mouse X");
        pitch -= xSpeed * Input.GetAxis("Mouse Y");

        if (pitch < -80)
        {
            pitch = -80;
        }
        if (pitch > 75)
        {
            pitch = 75;
        }
        miObj.localEulerAngles = new Vector3(pitch, yaw, 0.0f);

        if (Input.GetKey(KeyCode.W)) // ADELANTE
        {
            if (Input.GetKey(KeyCode.LeftShift)) //correr
                miObj.localPosition += miObj.forward * Time.deltaTime * runSpeed;
            else //caminar
                miObj.localPosition += miObj.forward * Time.deltaTime * walkSpeed;
        }
        if (Input.GetKey(KeyCode.S)) // ATRAS
        {

            miObj.localPosition -= miObj.forward * Time.deltaTime * walkSpeed;
        }
        if (Input.GetKey(KeyCode.A)) // IZQUIERDA
        {

            miObj.localPosition -= miObj.right * Time.deltaTime * walkSpeed;
        }
        if (Input.GetKey(KeyCode.D)) // DERECHA
        {

            miObj.localPosition += miObj.right * Time.deltaTime * walkSpeed;
        }
    }
}
