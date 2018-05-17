using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("selfDestruct", 2f);
	}

	void onCollisionEnter (Collision c){
        if (c.gameObject.layer == 10) {
            Debug.Log("Le ha dado al zombie: "+c.ToString());
            Destroy(c.gameObject);
        }
	
	}

	void selfDestruct(){
		
		Destroy (gameObject);
	}
}
