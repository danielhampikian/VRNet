using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SetupLocalPlayer : NetworkBehaviour {

    Renderer rend;
    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        if (isLocalPlayer)
        {
            //setup local player controls and stuff
            GetComponent<CustomPlayerControls>().enabled = true;

            //Set the main Color of the Material to green
            rend.material.SetColor("_Color", Color.green);

        }
        else
        {
            //deactivate controls and stuff
            GetComponent<CustomPlayerControls>().enabled = false;
            rend.material.SetColor("_Color", Color.red);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
