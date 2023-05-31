using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LifePLayer1 : MonoBehaviour
{
    public int totalHealth = 3;
    public float time = 0.1f;
    public Image Barrita1;
    

    private float health;
    private Animator anim;
    private SpriteRenderer sr;

    void Awake()
    {
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }


    void Start()
    {
        health = totalHealth;
        
        Barrita1.fillAmount = health / totalHealth;
    }

    public void AddDamage(int ammont)
    {
        health -= ammont;
        Debug.Log(health);
         
        Barrita1.fillAmount = health / totalHealth;
        anim.SetTrigger("Hit");

        if (health <= 0)
        {
            health = 0;
            SceneManager.LoadScene("Nivel1");
        }

    }

    public void AddHealth(int ammont)
    {
        health += ammont;
        Debug.Log(health);
        
        Barrita1.fillAmount = health / totalHealth;

        StartCoroutine(ChangeColor());
        if (health > totalHealth)
        {
            health = totalHealth;
        }
    }

    IEnumerator ChangeColor()
    {
        sr.color = Color.green;
        yield return new WaitForSeconds(time);
        sr.color = Color.white;

    }
}
