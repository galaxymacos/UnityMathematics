using System;
using UnityEngine;

public class DrawGraph : MonoBehaviour
{
    public int size = 20;
    public int maxWidth;
    public int maxHeight;

    private Coo2D startPointXAxis;
    private Coo2D endPointXAxis;

    private Coo2D startPointYAxis;
    private Coo2D endPointYAxis;

    private void Awake()
    {
        startPointXAxis = new Coo2D(maxWidth, 0);
        endPointXAxis = new Coo2D(-maxWidth, 0);
        startPointYAxis = new Coo2D(0, maxHeight);
        endPointYAxis = new Coo2D(0, -maxHeight);
    }


    private void Start()
    {
        DrawUtility.DrawLine(new Coo2D(0,-maxHeight), new Coo2D(0,maxHeight),1f, Color.green);
        DrawUtility.DrawLine(new Coo2D(-maxWidth,0), new Coo2D(maxWidth,0),1f, Color.red);

        int xInterval = (int) (maxWidth / (float) size);

        for (int x = -xInterval*size; x <= xInterval*size; x+=size)
        {
            DrawUtility.DrawLine(new Coo2D(x, -maxHeight), new Coo2D(x, maxHeight), 0.5f, Color.white);
        }

        int yInterval = (int) (maxHeight / (float) size);

        for (int y = -yInterval*size; y <= yInterval*size; y+=size)
        {
            DrawUtility.DrawLine(new Coo2D(-maxWidth, y), new Coo2D(maxWidth, y), 0.5f, Color.white);
        }
    }
}