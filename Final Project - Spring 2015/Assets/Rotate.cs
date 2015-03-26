using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	void Update() {
		transform.Rotate(Vector3.right * Time.deltaTime * 10f);
		transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
	}
}
