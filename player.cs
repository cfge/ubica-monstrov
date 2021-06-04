using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
      Transform body_tr;
    Transform cube_tr;
    Rigidbody cube_rb;
    float vertical;
    float horizontal;
    // Start is called before the first frame update
    void Start()
    {
        cube_tr = GetComponent<Transform>();
        cube_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
       
        vertical = Input.GetAxis("Vertical") * 10f;
        horizontal = Input.GetAxis("Horizontal") * 1f;
        cube_rb.AddForce(cube_tr.forward*vertical);
        cube_tr.Rotate(0,horizontal,0);
    }
    public void Poluchatel(float arg)
    {
        print(arg);
         transform.rotation = Quaternion.Euler(0,arg,0);
    }
       void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="bad")
        {
            Destroy(collision.gameObject);
            
        }
    }
}
