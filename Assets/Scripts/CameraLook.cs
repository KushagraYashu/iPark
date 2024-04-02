using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    // Start is called before the first frame update
    float xRotation = 0f;
    public float mouseSens = 100f;
    public Transform playerBody;


    void Start()
    {
        /*playerBody = this.transform;*/
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        xRotation -= mouseY;
        /*xRotation = Mathf.Clamp(xRotation, -60f, 60f);*/
        playerBody.Rotate(Vector3.up, mouseX, Space.Self);
        transform.localRotation = Quaternion.Euler(xRotation /*- Random.Range(camRecoilMin,camRecoilMax)*/, 0f, 0f);
    }
}
