using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejerci : MonoBehaviour
{

    public Vector3 A;
    public Vector3 B;
    private Vector3 sum;

    void OnDrawGizmosSelected()
    {
            // Draws a blue line from this transform to the target
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(transform.position, target.position);
        
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sum = A.x + B.x;
    }
}
