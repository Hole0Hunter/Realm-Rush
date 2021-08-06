using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    [SerializeField] [Range(0f, 5f)]float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        FindPath();

        this.transform.position = path[0].transform.position;
        StartCoroutine(PrintWaypointsList());
    }

    void FindPath()
    {
        path.Clear();
        GameObject[] waypoints = GameObject.FindGameObjectsWithTag("Path");
        foreach(GameObject waypoint in waypoints)
        {
            path.Add(waypoint.GetComponent<Waypoint>());
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PrintWaypointsList()
    {
        foreach(Waypoint waypoint in path)
        {
            Vector3 startPos = this.transform.position;
            Vector3 endPos = waypoint.transform.position;
            float travelPercent = 0f;

            transform.LookAt(endPos); // for the enemy to look towards his end position;

            while(travelPercent < 1f)
            {
                travelPercent += Time.deltaTime * speed;
                this.transform.position = Vector3.Lerp(startPos, endPos, travelPercent);
                yield return new WaitForEndOfFrame();
            }
        }

        Destroy(gameObject);
    }
}
