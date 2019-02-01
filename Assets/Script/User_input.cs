using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User_input : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    /*
    void Update()
    {

        if (Input.GetKeyDown("f"))
        {
            print("key F is pressed");
        }
        if (Input.GetKeyDown("w"))
        {
            Vector3 position = this.transform.position;
            position.z++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown("s"))
        {
            Vector3 position = this.transform.position;
            position.z--;
            this.transform.position = position;
        }
        if (Input.GetKeyDown("d"))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown("a"))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
    }
    */
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");

        Vector3 movement = new Vector3(moveHorizontal, jump, moveVertical);

        rb.AddForce(movement * speed);

        if (this.gameObject.transform.position.y < 0)
        {
            print("DU er faldet");
            this.gameObject.transform.position = new Vector3(3,1,5);
        }
    }
}
    

