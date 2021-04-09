using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Use Time.deltaTime to make Magnitude per second Instead of Magnitude per Frame
        //So, after putting Time.deltaTime it won't be Device dependent
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime ,
                            0,
                            Input.GetAxis("Vertical") * speed * Time.deltaTime );
    }
}
