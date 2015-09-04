using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {
	public GameObject explosionPrefab;
	
	void OnCollisionEnter(Collision collision) {
		Instantiate (explosionPrefab, transform.position, transform.rotation);
		Destroy (this);
	}
}