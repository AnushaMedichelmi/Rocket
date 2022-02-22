using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RocketController : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField]

    private float rocketRotationSpeed;

    [SerializeField]

    private float rocketThrustSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveRocketUp();
    }

    private void MoveRocketUp()
    {
        RocketThrust();

        RocketRotate();

       
    }

    private void RocketRotate()
    {

        float speed = 100.0f;

        //rb.freezeRotation = false;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rocketRotationSpeed = speed * Time.deltaTime;
            transform.Rotate(Vector3.back*rocketRotationSpeed);
            Debug.Log("Forward Rotation");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rocketRotationSpeed=speed*Time.deltaTime;
            transform.Rotate(Vector3.forward*rocketRotationSpeed);
            Debug.Log("Backward Rotation");
        }
    }

    private void RocketThrust()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            float thrust = 100.0f;
            rocketThrustSpeed=thrust*Time.deltaTime;
            rb.AddRelativeForce(Vector3.up);
            Debug.Log("Going Up");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        // string sceneName SceneManager.GetActiveScene().name;
        // SceneManager.LoadScene(sceneName);

        if (collision.gameObject.tag == "WallCollision")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


}
