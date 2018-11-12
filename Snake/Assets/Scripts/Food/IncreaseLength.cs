using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseLength : MonoBehaviour
{
    private FoodCollision _foodCol;
    private int _prevCols;

    [SerializeField] private GameObject _snakePart;
    


    private void Start()
    {
        _foodCol = gameObject.GetComponent<FoodCollision>();
        _prevCols = _foodCol.TimesCollided;
    }

    private void Update()
    {
        if (_foodCol.TimesCollided >= _prevCols)
        {
            _prevCols = _foodCol.TimesCollided;
        }
    }

    public void LengthIncrease()
    {
        Instantiate(_snakePart, new Vector3(gameObject.transform.position.x - 1 * _foodCol.TimesCollided +1, gameObject.transform.position.y), Quaternion.identity);
    }
}
