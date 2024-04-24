using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai11 : MonoBehaviour
{
    Vector3 newPosition;
    Camera m_Camera;
    private void Awake() {
        m_Camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Vector3 mousePosition = Input.mousePosition;
            Ray ray = m_Camera.ScreenPointToRay(mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            if (hit.collider != null) {
                string collider=hit.collider.name;
                GameObject.Find(collider).GetComponent<Renderer>().material.color=Color.red;
            }
        }
        
    }
}
