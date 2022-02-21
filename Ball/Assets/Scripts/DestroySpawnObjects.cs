using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySpawnObjects : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bonus")
        {
            Destroy(other.gameObject);
        }
    }
}
