using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float jumpFactor = 4.4f;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= jumpFactor;
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= jumpFactor;
    }
}
