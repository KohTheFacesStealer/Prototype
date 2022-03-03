using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

	public MovementController2D controller;

	float horizontalMove = 0f;
	public float runSpeed = 40f;
	bool jump = false;

	[Header("Idle Behaviour")]
	[SerializeField] private float idleDuration;
	private float idleTimer;

	[Header("Hero Animator")]
	[SerializeField] private Animator anim;

	// Start is called before the first frame update

	// Update is called once per frame
	void Update()
    {
		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		if(Input.GetButtonDown("Jump"))
		{
			jump = true;
		}
    }

	 void FixedUpdate()
	{
		//Move Character
		controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
		jump = false;
	}

	private void MoveInDirection(int direction)
	{
		idleTimer = 0;
		anim.SetBool("newRun", true);

		//Make enemy face direction
		//hero.localScale = new Vector3(Mathf.Abs(initScale.x) * direction,
			//initScale.y, initScale.z);

		//Make in that direction
		//hero.position = new Vector3(hero.position.x + Time.deltaTime * direction * speed, hero.position.y, hero.position.z);
	}
}
