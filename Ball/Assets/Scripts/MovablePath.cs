using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovablePath : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1600f);
    }
}
