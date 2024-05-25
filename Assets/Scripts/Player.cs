using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    public float moveSpeed = 5f;
    private Rigidbody rb;
    private float x;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed;

        rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);

        float mouseX = Input.GetAxis("Mouse X");

            x += 1 * mouseX;

            Quaternion angle = new Quaternion();
            angle.eulerAngles = new Vector3(0, transform.rotation.y + x, 0);
            transform.rotation = angle;


            Camera.main.transform.LookAt(transform);
            Camera.main.transform.Translate(Vector3.right * mouseX * Time.deltaTime * 2.8f);//the 2.8f is the sensibility
    }


}
