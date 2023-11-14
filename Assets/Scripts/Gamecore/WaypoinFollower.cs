using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypoinFollower : MonoBehaviour
{
    [SerializeField] private int wait_trigger;
    [SerializeField] private GameObject[] waypoints;
    [SerializeField] private int currentWaypointIndex = 0;
    [SerializeField] private int expected_variable = 0;
    private int trigger_variable = 0;
    [SerializeField] private float speed = 2f;
    private int strawberry = 0;
    [SerializeField] private int require = 0;

    // Update is called once per frame
    public void Update()
    {
        strawberry = ItemCollector.strawberries;
        trigger_variable = Box.variable;
        if (wait_trigger == 1 && trigger_variable == expected_variable)
        {
            Debug.Log("platform event true");
            Move();
        }
        if (wait_trigger == 2 && strawberry >= require)
        {
            Debug.Log("platform event true strawberry % " + strawberry);
            Move();
        }
        if (wait_trigger == 3 && strawberry >= require && trigger_variable == expected_variable)
        {
            Debug.Log("platform event combo true % " + strawberry);
            Move();
        }
        else if (wait_trigger == 0 && trigger_variable == 0)
        {
            Move();
        }
    }

    private void Move()
    {
        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
    }
}