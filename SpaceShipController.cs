using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{

    [Range(0.01f,10f)]
    public float turnMultiplier;

    Vector3 lastDir;

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
        pos += dir*Mathf.Clamp( Input.GetAxis("Vertical"), 0, 1)*0.3f;
        this.gameObject.transform.position = pos;
        lastDir = dir;
    }

    public void OnTriggerEnter(Collider other)
    {
        if ( other.gameObject.tag.Equals("HorizontalWalls")  ) {
            if (this.gameObject.transform.position.z > 0) {
                if (lastDir.z > 0) {
                    Vector3 pos = this.gameObject.transform.position;
                    pos.z = -15.6f;
                    this.gameObject.transform.position = pos;
                }
            }
        }

        if (other.gameObject.tag.Equals("HorizontalWalls"))
        {
            
            if (this.gameObject.transform.position.z < 0)
            {
                if (lastDir.z < 0)
                {
                    Vector3 pos = this.gameObject.transform.position;
                    pos.z = 15.6f;
                    this.gameObject.transform.position = pos;
                }
            }
        }


        if (other.gameObject.tag.Equals("VerticalWalls"))
        {

            if (this.gameObject.transform.position.x > 0)
            {
                if (lastDir.x > 0)
                {
                    Vector3 pos = this.gameObject.transform.position;
                    pos.x = -12f;
                    this.gameObject.transform.position = pos;
                }
            }
        }

        if (other.gameObject.tag.Equals("VerticalWalls"))
        {

            if (this.gameObject.transform.position.x < 0)
            {
                if (lastDir.x < 0)
                {
                    Vector3 pos = this.gameObject.transform.position;
                    pos.x = 12f;
                    this.gameObject.transform.position = pos;
                }
            }
        }

    }
}
