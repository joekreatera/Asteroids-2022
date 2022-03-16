using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterController : MonoBehaviour
{

    public GameObject originalBullet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Vector3 dir = this.gameObject.transform.TransformDirection(Vector3.forward);
            GameObject bullet = Instantiate(originalBullet, this.gameObject.transform.position, Quaternion.identity);
            Rigidbody body = bullet.GetComponent<Rigidbody>();
            body.AddForce(dir * 40.5f, ForceMode.Impulse);
            Physics.IgnoreCollision(this.gameObject.GetComponent<Collider>(), bullet.GetComponent<Collider>() );
        }    
    }
}
