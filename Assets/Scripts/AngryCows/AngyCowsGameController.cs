using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngyCowsGameController : MonoBehaviour
{
    private CowGameObject[] _cowGameObjects;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        //Get all CowgameObjects in our scene
        _cowGameObjects = gameObject.GetComponentsInChildren<CowGameObject>();

        int cowCount =0;
        //check how the game children are doing
        foreach (CowGameObject cowGameObject in _cowGameObjects) {
            if (cowGameObject.GetComponent<CowController>() != null) {
                if(cowGameObject.GetComponent<CowController>().hitTheGround == false)
                    cowCount++;
            }
        }


        if (cowCount == 0) {
            //Reset all objects
            foreach (CowGameObject cowGameObject in _cowGameObjects)
            {
                cowGameObject.ResetObjectPosition();

                if (cowGameObject.GetComponent<CowController>() != null)
                {    
                    cowGameObject.GetComponent<CowController>().ResetCow();
                }
            }
        }
    }
}
