using UnityEngine;
using System.Collections;

public class PlayerCont : MonoBehaviour {
public Rigidbody BulletPrefab

	// Update is called once per frame
	void Update () {
		if Input.GetMouseButtonDown(0)) {
			Rigidbody BulletInstance;
			BulletInstance = Instantiate(BulletPrefab, PlayerFront.position, ) as Rigidbody
				BulletInstance.AddForce(5000)
		}
	}
}
