using UnityEngine;

public class DrawGrid : MonoBehaviour
{

    [SerializeField] private int _gridSize;
    private GameObject[,] _grid;

    private void Draw()
    {
        for (int i = 0; i < _gridSize; i++)
        {
            for (int j = 0; j < _gridSize; j++)
            {
                _grid[i, j] = gameObject;
            }
            
        }    
    }
}
