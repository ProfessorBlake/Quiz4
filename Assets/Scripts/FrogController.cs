using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogController : MonoBehaviour
{
	public Animator Animator;
	public float WalkSpeed;

    void Start()
    {
        
    }
	
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
		{
			transform.position += new Vector3(-WalkSpeed, 0f, 0f) * Time.deltaTime;
			Animator.SetBool("walking", true);
		}
		else if (Input.GetKey(KeyCode.D))
		{
			transform.position += new Vector3(WalkSpeed, 0f, 0f) * Time.deltaTime;
			Animator.SetBool("walking", true);
		}
		else
		{
			Animator.SetBool("walking", false);
		}
	}
}
