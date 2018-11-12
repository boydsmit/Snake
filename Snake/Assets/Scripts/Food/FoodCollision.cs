using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollision : MonoBehaviour
{
    public int TimesCollided = 0;
    private RandomSpawning _spawning;
    [SerializeField] private GameObject _gameManager;
    private IncreaseLength _length;

    private void Start()
    {
        _spawning = _gameManager.GetComponent<RandomSpawning>();
        _length = gameObject.GetComponent<IncreaseLength>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Food"))
        {
            Destroy(collision.gameObject);
            TimesCollided += 1;
            _spawning.SpawnRandom();
            _length.LengthIncrease();
        }
    }
}
        