using System;
using UnityEngine;

public class DrawUtility: MonoBehaviour
{
    public static void DrawPoint(Coo2D position, float width, Color color)
    {
        GameObject line = new GameObject("Point_" + position.ToString());
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = color;
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, new Vector3(position.x - width/3.0f, position.y - width/3.0f));
        lineRenderer.SetPosition(1, new Vector3(position.x + width/3.0f, position.y + width/3.0f));
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;
    }
    
    public static void DrawLine(Coo2D startPos, Coo2D endPos, float width, Color color)
    {
        GameObject line = new GameObject("Line_" + startPos + "_"+ startPos);
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = color;
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, new Vector3(startPos.x, startPos.y));
        lineRenderer.SetPosition(1, new Vector3(endPos.x, endPos.y));
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;
    }
}