using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movments : MonoBehaviour
{
    private float speed = 20f;
    private float horizontalInput;
    private float boundary = 10f;
    public GameObject peluru;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);


        /*if (transform.position.x > boundary)
        {
            transform.position = new Vector3(boundary, 0f, 0f);
        }
        if (transform.position.x < boundary)
        {
            transform.position = new Vector3(-boundary, 0f, 0f);
        }*/
        if(Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(peluru, transform.position, peluru.transform.rotation);
        }
    }
}
