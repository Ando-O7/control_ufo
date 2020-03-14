using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufo_script : MonoBehaviour {

	private string mode;

	void Update () {
		if (mode == "fly") {
			transform.Translate (Vector3.up * Time.deltaTime * (transform.localScale.x * 0.2f));
			transform.RotateAround (transform.position, transform.up, Time.deltaTime * 150f);
		} else if (mode == "land") {
			transform.Translate (-Vector3.up * Time.deltaTime * (transform.localScale.x * 0.2f));
			transform.RotateAround (transform.position, transform.up, Time.deltaTime * 150f);
		} else if (mode == "left") {
			transform.Translate (Vector3.left * Time.deltaTime * (transform.localScale.x * 0.2f));
			transform.RotateAround (transform.position, transform.up, Time.deltaTime * 150f);
		} else if (mode == "right") {
			transform.Translate (Vector3.right * Time.deltaTime * (transform.localScale.x * 0.2f));
			transform.RotateAround (transform.position, transform.up, Time.deltaTime * 150f);
		} else {
			transform.Translate (0, 0, 0);
		}
	}

	public void Fly()
	{
		mode = "fly";
	}

	public void Land()
	{
		mode = "land";
	}

	public void Stop()
	{
		mode = "stop";
	}

	public void Left()
	{
		mode = "left";
	}

	public void Right()
	{
		mode = "right";
	}
}
