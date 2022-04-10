using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchScript : MonoBehaviour
{
    public GameObject one;
    public GameObject two;

    public void switchPlaces()
    {
        Vector3 swap = one.transform.position;
        one.transform.position = two.transform.position;
        two.transform.position = swap;
    }
}
