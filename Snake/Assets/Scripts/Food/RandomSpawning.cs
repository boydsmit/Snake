using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawning : MonoBehaviour
{
    [SerializeField] private GameObject _food;

    private int _randx;
    private int _randy;
    private DrawGrid _grid;

    private void Start()
    {
        _grid = GetComponent<DrawGrid>();
        SpawnRandom();
    
    }

    public void SpawnRandom()
    {
        GenerateXY();
        Spawn();
    }

    private void Spawn()
    {
        _grid.Grid[_randx, _randy] = Instantiate(_food, new Vector2(_randx, _randy), Quaternion.identity);
    }
    
    private void GenerateXY()
    {
        _randx = Random.Range(0, _grid.GridSize);
        _randy = Random.Range(0, _grid.GridSize);
    }
}
    