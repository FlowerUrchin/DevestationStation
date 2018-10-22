using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorExit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public GameObject triggerObject;

    private void OnTriggerEnter(Collider collider)
    {

        if (collider.tag == "Player")
        {

            if (triggerObject.GetComponent<Doors>().open == true)
                triggerObject.GetComponent<Doors>().Activate();

        }
    }

}
