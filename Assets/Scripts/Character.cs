using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] int hp = 90;


    bool isDead;

    [SerializeField] int currentHp;

    private void Start()
    {
        currentHp = hp;
    }

    public bool IsDead => isDead;

    public int Hp
    {
        get => currentHp;
        set
        {
            if (isDead) return;

            currentHp = value;

            if(currentHp <= 0)
            {
                Die();
            }


        }
    }

    public void Die()
    {
        Debug.Log("");
        isDead = true; 

    }

    public void healthChange(int hpchange)
    {
        currentHp += hpchange;
    }

}
