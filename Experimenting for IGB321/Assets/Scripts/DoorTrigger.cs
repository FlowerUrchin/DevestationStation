using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {

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

            if (triggerObject.GetComponent<Doors>().open == false)
                triggerObject.GetComponent<Doors>().Activate();        

        }
    }

}
