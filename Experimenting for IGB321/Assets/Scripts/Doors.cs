using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour {

    Animation animation;
    public bool open = false;

	// Use this for initialization
	void Start () {
        animation = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void Activate()
    {

        //If not playing an animation
        if (!animation.isPlaying)
        {
            //If closed, open
            if (!open)
            {
                animation.Play("Open Door");
                open = true;
            }
            //Otherwise if open, close
            else if (open)
            {
                animation.Play("Close Door");
                open = false;
            }
        }
    }

}
