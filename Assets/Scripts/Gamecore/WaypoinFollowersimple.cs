using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypoinFollowersimple : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    [SerializeField] private int currentWaypointIndex = 0;
    [SerializeField] private float speed = 2f;

    // Update is called once per frame
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
        SimpleMove();
    }

    private void SimpleMove()
    {
        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
        
    }
}