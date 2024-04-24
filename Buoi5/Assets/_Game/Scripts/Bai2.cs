using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bai2 : MonoBehaviour
{
    [SerializeField]private Transform a;
    [SerializeField]private Transform b;
    [SerializeField]private float speed;
    private bool isMovingRight=true;
    [SerializeField]private Rigidbody2D rb;
    private bool check;

    // Start is called before the first frame update
    private void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D other) {
        (b, a) = (a, b);
        isMovingRight=!isMovingRight;
        
    }

    private void OnTriggerExit2D(Collider2D other) {
        check=false;
    }

    // Update is called once per frame
    private void Update()
    {
        var step =  speed * Time.deltaTime; // calculate distance to move
        var step2=Vector3.right*Time.deltaTime;
        
        if(!check){
            //MoveToward
            // transform.position =Vector3.MoveTowards(transform.position, b.position,step);
            //Translate
            // if(isMovingRight){
            //     transform.Translate(step2, b);
            // }else{
            //     transform.Translate(-step2, b);
            // }
            //Velocity
            // rb.velocity = step*(b.position-a.position);
        }
    }

    
}
