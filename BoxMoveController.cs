using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMoveController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = this.gameObject.transform.eulerAngles;
        rot.y += Input.GetAxis("Horizontal");
        this.gameObject.transform.eulerAngles = rot;

        Vector3 v = new Vector3(1,1,1);

        Vector3 p = this.gameObject.transform.position;
        p = p + v* Input.GetAxis("Horizontal");
        this.gameObject.transform.position = p;

    }
}
