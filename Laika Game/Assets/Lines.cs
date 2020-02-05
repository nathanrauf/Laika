﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lines : MonoBehaviour
{
    public GameObject lineOrigin;
    public GameObject pickup;
    private Vector3 originLocation;
    private Vector3 pickupLocation;
    LineRenderer lineRenderer;
    LineRenderer lineRendererDown;
    public GameObject line;
    public Vector3[] points;

    public GameObject lineDown;
    public Vector3[] pointsLineDown;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = line.GetComponent<LineRenderer>();
        lineRenderer.enabled = false;

        lineRendererDown = lineDown.GetComponent<LineRenderer>();
        lineRendererDown.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<PlayerObjectMovement>().ball != null)
        {
            pickup = player.GetComponent<PlayerObjectMovement>().ball;
            originLocation = lineOrigin.transform.position;
            pickupLocation = pickup.transform.position;
            points[0] = originLocation;
            points[1] = pickupLocation;
            lineRenderer.SetPositions(points);
            lineRenderer.enabled = true;

            pointsLineDown[0] = pickupLocation;
            Vector3 downPos = pickupLocation - new Vector3(0f, 30f, 0f);
            pointsLineDown[1] = downPos;
            lineRendererDown.SetPositions(pointsLineDown);
            lineRendererDown.enabled = true;
        } else
        {
            lineRenderer.enabled = false;
            lineRendererDown.enabled = false;
        }
    }
}
