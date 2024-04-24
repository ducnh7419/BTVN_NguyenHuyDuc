using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai4 : MonoBehaviour
{
    [SerializeField] private Transform dest;
     // Time when the movement started.
    private float startTime;
    private float journeyLength;
    [SerializeField]private float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(transform.position, dest.position);
    }

    // Update is called once per frame
    void Update()
    {
        // Distance moved equals elapsed time times speed..
        float distCovered = (Time.time - startTime) * speed;

        // Fraction of journey completed equals current distance divided by total distance.
        float fractionOfJourney = distCovered / journeyLength;
        transform.position = Vector3.Lerp(transform.position, dest.position, fractionOfJourney);
    }
}
