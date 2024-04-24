using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai8 : MonoBehaviour
{
    [SerializeField] private Transform a;
    [SerializeField] private Transform b;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(IEDelayMove());
    }

    IEnumerator IEDelayMove(){      
        yield return new WaitForSeconds(1f);
        var step=Time.deltaTime*speed;
        transform.position=Vector3.MoveTowards(transform.position,b.position,step);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        (b, a) = (a, b);
        
    }

    
}
