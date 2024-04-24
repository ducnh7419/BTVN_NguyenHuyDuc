using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai3AndBai5 : MonoBehaviour
{
    // Start is called before the first frame update
    private List<Vector3> points;
    private Vector3 startPoint;
    [SerializeField]private float speed;
    private bool isFinished;
    private int i;
    void Start()
    {
        OnInit();
        startPoint=transform.position;
    }

    public void OnInit(){
        points=new List<Vector3>();
        for (int i = 0;i<3;i++){
            points.Add(new Vector3(Random.Range(-11f,11f),Random.Range(-5f,5f),0));           
        }
        i=0;
        isFinished=false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dest=Vector3.zero;
        if(i<points.Count){
            dest=points[i];
        }else{
            dest=startPoint;
            isFinished=true;
        }
        if(Vector3.Distance(transform.position,dest)<=0.001f){
            i+=1;
            if(isFinished){
                Debug.Log("Finished");
                OnInit();
            }
        }
        var step =  speed * Time.deltaTime; // calculate distance to move
        transform.position=Vector3.MoveTowards(transform.position,dest,step);

    }
}
