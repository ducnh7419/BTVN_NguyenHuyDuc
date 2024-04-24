using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai12 : MonoBehaviour
{
    Vector3 newPosition;
    Camera m_Camera;
    private bool isMoving;
    [SerializeField]private float speed;


    [SerializeField] private Transform dest;
    private void Awake() {
        m_Camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        var step =  speed * Time.deltaTime;
        if(Input.GetMouseButtonDown(1)){
            newPosition = Input.mousePosition;
            newPosition.z=transform.position.z-m_Camera.transform.position.z;
			newPosition=m_Camera.ScreenToWorldPoint(newPosition);
            isMoving=true;
            
        }
        if(isMoving){
            if(Vector3.Distance(transform.position,newPosition)<0.1f){
                isMoving=false;
                return;
            }
            transform.Translate(speed * Time.deltaTime * (newPosition-transform.position).normalized);
        }
        RaycastHit2D hit= Physics2D.Raycast(transform.position,Vector3.left,0.8f);
        Debug.DrawLine(transform.position,transform.position+Vector3.right*0.8f,Color.red);
        if(hit.collider != null &&hit.collider.name!="Player"){         
            Debug.Log("Complete");
        }

        
    }
}
