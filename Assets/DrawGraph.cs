using UnityEngine;

public class DrawGraph : MonoBehaviour
{
    public int size = 20;

    private Coo2D startPointXAxis = new Coo2D(160, 0);
    private Coo2D endPointXAxis = new Coo2D(-160, 0);
    
    private Coo2D startPointYAxis = new Coo2D(0, 100);
    private Coo2D endPointYAxis = new Coo2D(0, -100);
    
    
    
    
    private void Start()
    {
        DrawUtility.DrawLine(new Coo2D(0,-100), new Coo2D(0,100),1f, Color.green);
        DrawUtility.DrawLine(new Coo2D(-160,0), new Coo2D(160,0),1f, Color.red);

        for (int x = -160; x <= 160; x+=size)
        {
            DrawUtility.DrawLine(new Coo2D(x, -100), new Coo2D(x, 100), 0.5f, Color.white);
        }

        for (int y = -100; y <= 100; y+=size)
        {
            DrawUtility.DrawLine(new Coo2D(-160, y), new Coo2D(160, y), 0.5f, Color.white);
        }
    }
}