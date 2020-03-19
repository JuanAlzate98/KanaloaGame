﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tortuga : MonoBehaviour
{
    private bool isDead;
    private Rigidbody2D rb2d;
    private Animator anim;
    public float upForce=200f;
    private RotateTor rotateTor;
   
   


private void Awake(){
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rotateTor = GetComponent<RotateTor>();

}
    // Start is called before the first frame update
  private  void Start()
    {

    }


    // Update is called once per frame
    private void Update(){
    if (isDead == false){
            if (Input.GetMouseButtonDown(0)) {

                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));
                anim.SetTrigger("Flap");
                SoundSystem.instance.PlaySwiming();
        }
    }

    }

    private void OnCollisionEnter2D(Collision2D collision ){
        isDead =true;
        anim.SetTrigger("Die");
        GameController.instance.TorDie();
        SoundSystem.instance.PlayDie();
        rotateTor.enabled = false;
    }

}