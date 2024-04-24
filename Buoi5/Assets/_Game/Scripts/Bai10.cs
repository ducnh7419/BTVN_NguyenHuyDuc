using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai10 : MonoBehaviour
{
    [SerializeField] private Transform a;
    [SerializeField] private Transform b;
    [SerializeField] private float speed=5f;
    private Vector3 startPoint;
    // Start is called before the first frame update
    void Start()
    {
        startPoint=transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Vector3.Distance(startPoint,transform.position)<=0.01f){
            StartCoroutine(IEDelayMoveRandomly());
        }else{
            var step=Time.deltaTime*speed;
            transform.position=Vector3.MoveTowards(transform.position,b.position,step);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        (b, a) = (a, b);
        
    }
    
    IEnumerator IEDelayMoveRandomly(){
        yield return new WaitForSeconds(Random.Range(1, 3));
        var step=Time.deltaTime*speed;
        transform.position=Vector3.MoveTowards(transform.position,b.position,step);
    }
}
