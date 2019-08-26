using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{

    public float CurrentHealth { get; set; }
    public float MaxHealth { get; set; }


    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = 100f;
        CurrentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void DealDamage(float damageValue)
    {
        CurrentHealth -= damageValue;
        Debug.Log(CurrentHealth);
        if (CurrentHealth <= 0)
            Die();
    }

    void Die()
    {
        CurrentHealth = 0;
        Debug.Log("you dead");
        gameObject.SetActive(false);
    }

  private void OnParticleCollision(GameObject other)
    {
        DealDamage(1f);
    }



}
