using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float speed = 20f;
	public int damage = 40;
	public Rigidbody2D rb;
	public GameObject impactEffect;

	
	void Start () {
		rb.velocity = transform.right * speed;
	}

	void OnTriggerEnter2D (Collider2D hitInfo)
	{
        EnemyHealth enemy = hitInfo.GetComponent<EnemyHealth>();
		if (enemy != null)
		{
			enemy.AddDamage(damage);
		}

		Instantiate(impactEffect, transform.position, transform.rotation);

		Destroy(gameObject);
	}
	
}
