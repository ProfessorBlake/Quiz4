using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogController : MonoBehaviour
{
	public Animator Animator;
	public AudioSource AudioSource;
	public float WalkSpeed;

	void Update()
    {
		//Move left
        if(Input.GetKey(KeyCode.A))
		{
			transform.position += new Vector3(-WalkSpeed, 0f, 0f) * Time.deltaTime;

		}
		//Move right
		else if (Input.GetKey(KeyCode.D))
		{
			transform.position += new Vector3(WalkSpeed, 0f, 0f) * Time.deltaTime;

		}
		//Idle
		else
		{
			
		}
	}
}
