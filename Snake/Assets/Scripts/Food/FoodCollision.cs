using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollision : MonoBehaviour
{
    private int _timesCollided = 0;
    private RandomSpawning _spawning;
    [SerializeField] private GameObject _gameManager;

    private void Start()
    {
        _spawning = _gameManager.GetComponent<RandomSpawning>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Food"))
        {
            Destroy(collision.gameObject);
            _timesCollided += 1;
            _spawning.SpawnRandom();
        }
    }
}
        