using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

[ExecuteAlways] // This tag will make sure that the script is executed even in the Scene View.
public class CoordinateLabler : MonoBehaviour
{
    TextMeshPro label;
    public Vector2Int coordinates = new Vector2Int();

    // Start is called before the first frame update
    void Awake()
    {
        label = this.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayCoordinates();
        UpdateObjectName();
    }

    void DisplayCoordinates()
    {
        /* Since the snapping is in the order of 10s, we need to divide
           the resultant coordinates by 10                              */
        int snapping = Mathf.RoundToInt(UnityEditor.EditorSnapSettings.move.x);
        coordinates.x = (Mathf.RoundToInt(transform.parent.position.x))/snapping;
        coordinates.y = (Mathf.RoundToInt(transform.parent.position.z))/snapping;

        label.text = coordinates.ToString();
    }

    void UpdateObjectName()
    {
        transform.parent.name = coordinates.ToString();
    }
}
