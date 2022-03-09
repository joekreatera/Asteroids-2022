using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{

    [Range(0.01f,10f)]
    public float turnMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = this.gameObject.transform.eulerAngles;
        rot.y += Input.GetAxis("Horizontal") * turnMultiplier;
        this.gameObject.transform.eulerAngles = rot;

        Vector3 pos = this.gameObject.transform.position;
        Vector3 dir = this.gameObject.transform.TransformDirection(Vector3.forward);
        pos += dir*Input.GetAxis("Vertical");
        this.gameObject.transform.position = pos;
    }
}
