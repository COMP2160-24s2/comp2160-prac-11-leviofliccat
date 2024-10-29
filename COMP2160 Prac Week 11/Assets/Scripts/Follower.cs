using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;
    [SerializeField] private GameObject targetObjectSecond;
    [SerializeField] private float step;



    private float radius;
    void Start()
    {
        radius = targetObject.GetComponent<SphereCollider>().radius;
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = targetObject.transform.position;
        transform.position = Vector3.MoveTowards(targetObject.transform.position , targetObjectSecond.transform.position ,step);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
