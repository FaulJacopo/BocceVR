using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagneticKey : MonoBehaviour
{
    public GameObject door;
    public GameObject key;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals(key.name))
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
            door.GetComponent<ConfigurableJoint>().angularYMotion = ConfigurableJointMotion.Free;
        } else
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
