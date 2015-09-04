using UnityEngine;
using System.Collections;

public class RifleController : MonoBehaviour {
	
	public GameObject barrel;
	public GameObject shellHole;
	public Rigidbody bulletPrefab;
	public Rigidbody shellPrefab;
	
	void Update () {
		if(Input.GetMouseButtonDown(0)) {
			Rigidbody bullet = (Rigidbody) Instantiate(bulletPrefab,
			                                           barrel.transform.position,
			                                           transform.rotation);
			bullet.transform.rotation *= Quaternion.Euler(-90, 0, 0);
			bullet.velocity = -transform.forward * 100;
			
			Rigidbody shell = (Rigidbody) Instantiate(shellPrefab,
			                                          shellHole.transform.position,
			                                          transform.rotation);
			shell.transform.rotation *= Quaternion.Euler(-90, 0, 0);
			shell.velocity = transform.up * 3;
			shell.angularVelocity = new Vector3 (10, 10, 10);
		}
	}
}