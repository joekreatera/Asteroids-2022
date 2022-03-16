using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}
