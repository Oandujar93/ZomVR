using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour {

	public Transform crosshair;
	public GameObject projectile;
	private SteamVR_TrackedController controller;

	// Use this for initialization
	void Start () {
		controller = GetComponent <SteamVR_TrackedController> ();
		controller.TriggerClicked += Shoot;

		
	}
	
	// Update is called once per frame
	void Shoot (object sender, ClickedEventArgs e) {
		if (projectile) {

			GameObject newProjectile = Instantiate (projectile, crosshair.gameObject.transform.position, transform.rotation);
			newProjectile.GetComponent <Rigidbody> ().AddForce (transform.forward * 20f, ForceMode.VelocityChange);

		}
	}
}
