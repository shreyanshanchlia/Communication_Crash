using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {

	public GameObject p1;
	public GameObject p2;
	public GameObject p3;
	public GameObject p4;
	public GameObject p5;
	public GameObject p12;

	bool T = false;

	public GameObject r2;
	public GameObject r3;
	public GameObject r4;
	public GameObject r5;
	public GameObject r6;
	public GameObject r;

	Vector3 v = new Vector3();
	// Use this for initialization
	void Start ()
	{
		p1.SetActive(false);
		p2.SetActive(false);
		p3.SetActive(false);
		p4.SetActive(false);
		p5.SetActive(false);
		p12.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		v = new Vector3(-7.6f, -3.58f, 5.125f);
		if(Input.GetKeyUp("1"))
		{
			p1.SetActive(true);
			p2.SetActive(false);
			p3.SetActive(false);
			p4.SetActive(false);
			p5.SetActive(false);
			p12.SetActive(false);

			//r2.transform.rotation = Quaternion.EulerRotation(0, 180, 0);
			r2.transform.eulerAngles = new Vector3(0, 180, 0);
			r3.transform.eulerAngles = new Vector3(0, 0, 0);
			r4.transform.eulerAngles = new Vector3(0, 0, 0);
			r5.transform.eulerAngles = new Vector3(0, 0, 0);
			r6.transform.eulerAngles = new Vector3(0, 0, 0);
		}

		if (Input.GetKeyUp("2"))
		{
			p1.SetActive(false);
			p2.SetActive(true);
			p3.SetActive(false);
			p4.SetActive(false);
			p5.SetActive(false);
			p12.SetActive(false);

			r2.transform.eulerAngles = new Vector3(0, 0, 0);
			r3.transform.eulerAngles = new Vector3(0, 180, 0);
			r4.transform.eulerAngles = new Vector3(0, 0, 0);
			r5.transform.eulerAngles = new Vector3(0, 0, 0);
			r6.transform.eulerAngles = new Vector3(0, 0, 0);
		}

		if (Input.GetKeyUp("3"))
		{
			p1.SetActive(false);
			p2.SetActive(false);
			p3.SetActive(true);
			p4.SetActive(false);
			p5.SetActive(false);
			p12.SetActive(false);

			r2.transform.eulerAngles = new Vector3(0, 0, 0);
			r3.transform.eulerAngles = new Vector3(0, 0, 0);
			r4.transform.eulerAngles = new Vector3(0, 180, 0);
			r5.transform.eulerAngles = new Vector3(0, 0, 0);
			r6.transform.eulerAngles = new Vector3(0, 0, 0);
		}

		if (Input.GetKeyUp("4"))
		{
			p1.SetActive(false);
			p2.SetActive(false);
			p3.SetActive(false);
			p4.SetActive(true);
			p5.SetActive(false);
			p12.SetActive(false);

			r2.transform.eulerAngles = new Vector3(0, 0, 0);
			r3.transform.eulerAngles = new Vector3(0, 0, 0);
			r4.transform.eulerAngles = new Vector3(0, 0, 0);
			r5.transform.eulerAngles = new Vector3(0, 180, 0);
			r6.transform.eulerAngles = new Vector3(0, 0, 0);
		}

		if (Input.GetKeyUp("5"))
		{
			p1.SetActive(false);
			p2.SetActive(false);
			p3.SetActive(false);
			p4.SetActive(false);
			p5.SetActive(true);
			p12.SetActive(false);

			r2.transform.eulerAngles = new Vector3(0, 0, 0);
			r3.transform.eulerAngles = new Vector3(0, 0, 0);
			r4.transform.eulerAngles = new Vector3(0, 0, 0);
			r5.transform.eulerAngles = new Vector3(0, 0, 0);
			r6.transform.eulerAngles = new Vector3(0, 180, 0);
		}

		if (Input.GetKeyUp("6"))
		{
			p1.SetActive(false);
			p2.SetActive(false);
			p3.SetActive(false);
			p4.SetActive(false);
			p5.SetActive(false);
			p12.SetActive(true);

			r2.transform.eulerAngles = new Vector3(0, 0, 0);
			r3.transform.eulerAngles = new Vector3(0, 0, 0);
			r4.transform.eulerAngles = new Vector3(0, 0, 0);
			r5.transform.eulerAngles = new Vector3(0, 0, 0);
			r6.transform.eulerAngles = new Vector3(0, 0, 0);
			T = true;
		}

		if(T)
		{
			//	Animator.r.GetComponent<Animator>().enabled = false;
			r.GetComponent<Animator>().enabled = false;
			r.transform.position = v;
		}

	}
}
