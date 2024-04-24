using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai7 : MonoBehaviour
{
    [SerializeField] private Transform leftPoint;
    [SerializeField] private Transform rightPoint;
    [SerializeField] private Transform downPoint;
    [SerializeField] private float speed;
    private Vector3 dest;
    private Vector3 prevDest;

    private enum Pos{
        Left,
        Right,
        Down
    }

    // Start is called before the first frame update
    private void Start()
    {
        OnInit();
        prevDest=transform.position;
    }

    public void OnInit(){     
        float dist;
        do{
            int rdn=Random.Range((int)Pos.Left, (int)Pos.Down+1);
            if(rdn==(int)Pos.Left){
                dest=leftPoint.position;
            }
            else if(rdn==(int)Pos.Right){
                dest=rightPoint.position;
            }else if(rdn==(int)Pos.Down){
                dest=downPoint.position;
            }
            dist=Vector3.Distance(prevDest,dest);
        }while(dist<=0.001f);
    }

    // Update is called once per frame
    private void Update()
    {
        var step=Time.deltaTime*speed;
        transform.position=Vector3.MoveTowards(transform.position,dest,step);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        OnInit();
        prevDest=dest;
    }
}
