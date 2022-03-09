using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box2MoveController : MonoBehaviour
{
    public GameObject otherObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.gameObject.transform.position;
        pos.x = Input.GetAxis("Vertical");
        this.gameObject.transform.position = pos;

        Vector3 rot = otherObject.transform.eulerAngles;
        this.gameObject.transform.eulerAngles = rot;

    }
}
