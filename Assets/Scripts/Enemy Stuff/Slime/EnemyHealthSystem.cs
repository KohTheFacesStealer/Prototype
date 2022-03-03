using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthSystem : MonoBehaviour
{

	public Animator animator;

	public int maxHealth = 100;
	public int currentHealth;

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
	}
	public void TakeDamage(int damage)
	{
		currentHealth -= damage;

		animator.SetTrigger("hurt");

		if (currentHealth <= 0)
		{
			Die();
		}

	}
	// Update is called once per frame
	void Die()
	{
		Debug.Log("Enemy died!");

		animator.SetBool("IsDead", true);

		GetComponent<Collider2D>().enabled = false;
		this.enabled = false;
		
	}
}
