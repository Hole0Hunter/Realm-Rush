using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Mouse inputs will be written in this script because this script is attached to the tiles 
   and we need to access the name of the tiles, when we click on the respective tile.       */
public class Waypoint : MonoBehaviour
{
    [SerializeField] bool isPlaceable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (isPlaceable)
        {
            Debug.Log(this.name);
        }
    }
}
