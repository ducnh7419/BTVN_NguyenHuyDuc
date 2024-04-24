using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai6 : MonoBehaviour
{
    [SerializeField]private Rigidbody2D rb;
    [SerializeField]private float speed ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var step=speed*Time.deltaTime;
        if(Input.GetKey(KeyCode.LeftArrow)){
            Debug.Log("A");
            rb.velocity = Vector2.left * step;
        }else if(Input.GetKey(KeyCode.RightArrow)){
            rb.velocity = Vector2.right * step;
        }else if(Input.GetKey(KeyCode.UpArrow)){
            rb.velocity = Vector2.up * step;
        }else if(Input.GetKey(KeyCode.DownArrow)){
            rb.velocity = Vector2.down * step;
        }
    }
    
}
