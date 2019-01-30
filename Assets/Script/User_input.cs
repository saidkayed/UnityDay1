using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User_input : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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

    
}
