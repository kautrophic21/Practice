using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //[SerializeField] Vector3 target;
    //float speed = 2f;

    float acceleration = 10f;
    float deacc = 10f;
    float maxspeed = 5f;

    float currenspeed = 0f;

    float jumpspeed = 5f;

    Rigidbody rb;

    public KeyCode jumpKey = KeyCode.Space;

    public KeyCode moveKey = KeyCode.RightArrow;


    //float jump;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // jump = Input.GetAxis("Space");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jumpKey))
        {
            Jump();
        }

        if (Input.GetKeyDown(moveKey)) {

            MoveRight();
        }

        //if (moveInput != 0f) {

        //    currenspeed = Mathf.MoveTowards(currenspeed, maxspeed, acceleration * Time.deltaTime * Mathf.Sign(moveInput));
        //}
        //else {

        //    currenspeed = Mathf.MoveTowards(currenspeed, 0f, deacc * Time.deltaTime);
        //}


        //transform.Translate(Vector3.up* currenspeed * Time.deltaTime);

    }

    void Jump() {

        rb.AddForce(Vector3.up * jumpspeed, ForceMode.Impulse);
    }

    void MoveRight() {

        if(moveKey != 0f) {

            currenspeed = Mathf.MoveTowards(currenspeed, maxspeed, acceleration * Time.deltaTime * Mathf.Sign(+1f));
        }
        else {

            currenspeed = Mathf.MoveTowards(currenspeed, 0f, deacc * Time.deltaTime);
        }

        transform.Translate(Vector3.right * currenspeed * Time.deltaTime);
    }


    }

