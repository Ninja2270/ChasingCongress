using System.Collections;
using UnityEngine;

public class Waypointmover : MonoBehaviour
{
    public Transform wayPointParent;
    public float moveSpeed = 10f;
    public float waitTime = 2f;
    public bool loopWayPoints = true;

    private Transform[] wayPoints;
    private int currentWaypointIndex;
    private bool isWaiting;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        wayPoints = new Transform[wayPointParent.childCount];

        for(int i = 0; i < wayPointParent.childCount; i++)
        {
            wayPoints[i] = wayPointParent.GetChild(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
       // if (PauseController.IsGamePaused || isWaiting)
        {
         //   return;
        }
        MoveToWaypoint();
        
    }
    void MoveToWaypoint()
    {
        Transform target = wayPoints[currentWaypointIndex];

        transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);

        if(Vector2.Distance(transform.position, target.position) < 0.1f)
        {
            StartCoroutine(WaitAtWayPoint());
        }
    }

    IEnumerator WaitAtWayPoint()
    {
        isWaiting = true;
        yield return new WaitForSeconds(waitTime);

        // if looping is enabled: increment currentWaypointIndex and wrap around if needed
        // if not looping: increment currentwaypointindext but don't exceed last waypoint.
        currentWaypointIndex = loopWayPoints ? (currentWaypointIndex + 1) % wayPoints.Length : Mathf.Min(currentWaypointIndex + 1, wayPoints.Length - 1);

        isWaiting = false;
    }
}
