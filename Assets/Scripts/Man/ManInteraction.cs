using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManInteraction : MonoBehaviour
{
    [SerializeField, Range(0.1f, 5f)] private float distanceRay;
    private void OnTriggerEnter2D(Collider2D other)
    {
   
        if (other.CompareTag("Actor"))
        {
            Debug.Log("Зашел");
            other.GetComponent<Actor>().StartAction();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    { 
        if (other.CompareTag("Actor"))
        {
            Debug.Log("Вышел");
            other.GetComponent<Actor>().StopAction();
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x + distanceRay, transform.position.y));
    }

    private void Update()
    {
        Ray2D ray = new Ray2D(transform.position, transform.forward * 3);
        Debug.DrawRay(ray.origin, ray.direction);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, distanceRay);
        if (hit && Input.GetKey(KeyCode.F))
        {
            if (hit.collider.CompareTag("Actor"))
            {
                hit.collider.GetComponent<Actor>().StartAction();
            }
        }
    }
}
