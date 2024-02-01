using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBound : MonoBehaviour
{
    private float upboundry = 20.0f;
    private float downboundry = -5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > upboundry || transform.position.z < downboundry)
        {
            Destroy(gameObject);
        }

    }
}
