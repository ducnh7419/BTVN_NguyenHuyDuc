using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai9 : MonoBehaviour
{
    [SerializeField] private Transform a;
    [SerializeField] private Transform b;
    [SerializeField] private float time;
    [SerializeField] private float speed;
     // Total distance between the markers.
    private float journeyLength;
    // Start is called before the first frame update
    void Start()
    {
        // Calculate the journey length.
        journeyLength = Vector3.Distance(transform.position, b.position);
    }

    // Update is called once per frame
    void Update()
    {
        float distCovered = time * speed*Time.deltaTime;
        float fractionOfJourney = distCovered / journeyLength;
        transform.position=Vector3.Lerp(transform.position,b.position, fractionOfJourney);
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        (b, a) = (a, b);
        
    }
}
