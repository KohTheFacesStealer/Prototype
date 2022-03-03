using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroCombat : MonoBehaviour
{

	public Animator animator;

	public Transform attackPoint;
	public float attackRange = 0.5f;
	public LayerMask enemyLayers;

	public int attackDamage = 40;

    // Start is called before the first frame update
    void Update()
    {
		if(Input.GetKeyDown(KeyCode.Mouse0))
		{
			Attack1();
		}

		if (Input.GetKeyDown(KeyCode.Mouse1))
		{
			Attack2();
		}

		if (Input.GetKeyDown(KeyCode.Q))
		{
			Attack3();
		}

	}

    // Update is called once per frame
    void Attack1()
    {
		animator.SetTrigger("hAttack1");

		//Detect enemies in range
		Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

		//Damage them
		foreach (Collider2D enemy in hitEnemies)
		{
			enemy.GetComponent<EnemyHealthSystem>().TakeDamage(attackDamage);
			enemy.GetComponent<gEnemyHealthSystem>().TakeDamage(attackDamage);
		}
    }

	void Attack2()
	{
		animator.SetTrigger("hAttack2");

		//Detect enemies in range
		Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

		//Damage them
		foreach (Collider2D enemy in hitEnemies)
		{
			enemy.GetComponent<EnemyHealthSystem>().TakeDamage(attackDamage);
			enemy.GetComponent<gEnemyHealthSystem>().TakeDamage(attackDamage);
		}
	}

	void Attack3()
	{
		animator.SetTrigger("hAttack3");

		//Detect enemies in range
		Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

		//Damage them
		foreach (Collider2D enemy in hitEnemies)
		{
			enemy.GetComponent<EnemyHealthSystem>().TakeDamage(attackDamage);
			enemy.GetComponent<gEnemyHealthSystem>().TakeDamage(attackDamage);
		}
	}

	private void OnDrawGizmosSelected()
	{

		if (attackPoint == null)
			return;

		Gizmos.DrawWireSphere(attackPoint.position, attackRange);
	}
}
