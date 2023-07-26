using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabWeapon : MonoBehaviour {

	public Transform firePoint;
	public GameObject bulletPrefab;
    public Animator animator;
	

	void Update () {
		if (Input.GetButtonDown("Fire2"))
		{
			Shoot();
		}
	}

	void Shoot ()
	{
		Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
       animator.SetTrigger("Shoot");
        
    }
    


}
