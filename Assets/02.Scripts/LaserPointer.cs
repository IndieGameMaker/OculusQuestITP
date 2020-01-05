using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPointer : MonoBehaviour
{
    private LineRenderer line;
    public float maxDistance = 20.0f;
    public Color laserColor = Color.green;

    private RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        CreateLine();
    }

    void CreateLine()
    {
        line = this.gameObject.AddComponent<LineRenderer>();
        line.useWorldSpace = false;
        line.positionCount = 2;
        line.SetPosition(0, Vector3.zero);
        line.SetPosition(1, new Vector3(0, 0, maxDistance));
        line.startWidth = 0.03f;
        line.endWidth   = 0.005f;
        line.material = new Material(Shader.Find("Unlit/Color"));
        line.material.color = laserColor;

    }


    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance))
        {
            line.SetPosition(1, new Vector3(0, 0, hit.distance));
        }
    }
}
