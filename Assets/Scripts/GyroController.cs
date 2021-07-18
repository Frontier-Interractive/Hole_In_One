using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroController : MonoBehaviour
{
    private float speed;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10000;
        Input.gyro.enabled = true;
        rb = GetComponent<Rigidbody>();
    } 
    // Update is called once per frame
    void Update()
    {

        //transform.rotation = Quaternion.Euler(Mathf.Clamp( transform.rotation.x, -0.2f, 0.2f), transform.rotation.y, Mathf.Clamp( transform.rotation.z, -0.2f, 0.2f));
    
    }

    private void FixedUpdate()
    {
        float x =  Input.acceleration.x;
        float y = Input.acceleration.y;

        Debug.Log(new Vector3(x, y, 0));

        rb.AddForce(new Vector3(x, 0, y) * speed * Time.deltaTime );
    }
}
