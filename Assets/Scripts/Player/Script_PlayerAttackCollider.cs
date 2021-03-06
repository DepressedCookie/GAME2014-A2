﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_PlayerAttackCollider : MonoBehaviour
{
    public int Damage = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            collision.GetComponent<Script_Enemy>().ApplyDamage(Damage);
            collision.GetComponent<Animator>().SetTrigger("Hurt");
        }
    }
}
