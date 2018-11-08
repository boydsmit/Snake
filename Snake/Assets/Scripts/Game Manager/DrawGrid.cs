using UnityEngine;

public class DrawGrid : MonoBehaviour
{

    public int GridSize;
    public GameObject[,] Grid;
    

    private void Start()
    {
        Grid = new GameObject[GridSize,GridSize];
        Draw();
    }

    private void Draw()
    {
        for (int i = 0; i < GridSize; i++)
        {
            for (int j = 0; j < GridSize; j++)
            {
                Grid[i, j] = gameObject;
            }
            
        }    
    }
}
