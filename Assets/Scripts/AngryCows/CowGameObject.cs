using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowGameObject : MonoBehaviour
{
    private Vector3 _startPosition;
    private Quaternion _startRotation;

    // Start is called before the first frame update
    void Start()
    {
        _startPosition = gameObject.transform.position;
        _startRotation = gameObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetObjectPosition() {
        //remove physics
        gameObject.GetComponent<Rigidbody>().useGravity = false;
        gameObject.GetComponent<Rigidbody>().isKinematic = true;

        //reset position and rotation
        gameObject.transform.rotation = _startRotation;
        gameObject.transform.position = _startPosition;

        Debug.Log("Reset Object");
 
        //add physics
        gameObject.GetComponent<Rigidbody>().useGravity = true;
        gameObject.GetComponent<Rigidbody>().isKinematic = false;
    }
}
