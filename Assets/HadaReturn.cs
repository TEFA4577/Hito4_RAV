using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HadaReturn : MonoBehaviour
{
        public GameObject hada;

    // Update is called once per frame
    public void onClick()
    {
        Vector3 newPosition = new Vector3(0, 0, 0);
        Quaternion newRotation = Quaternion.identity;
        Instantiate(hada, newPosition, newRotation);
    }
}
