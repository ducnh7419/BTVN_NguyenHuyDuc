using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai14B : MonoBehaviour
{
    
    [SerializeField] float speed;
    // Start is called before the first frame update
    [SerializeField]private Rigidbody2D rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal=Input.GetAxisRaw("Horizontal");
         if(Mathf.Abs(horizontal)>0.1f){
            rb.velocity=new Vector2(horizontal*Time.deltaTime*speed,rb.velocity.y);
            //horizontal>0=> tra ve 0, con khong thi tra ve 180
            transform.rotation=Quaternion.Euler(new Vector3(0,horizontal>0 ? 0 : 180,0));
         }
    }
}
