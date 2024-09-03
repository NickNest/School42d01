using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovingPlatform : MonoBehaviour
{
    [SerializeField] Transform[] _movePoints;
    [SerializeField] float _speed;
    private int _indexOfCurrentPoint = 0;

    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, _movePoints[_indexOfCurrentPoint].position, _speed * Time.deltaTime);
        if (transform.position == _movePoints[_indexOfCurrentPoint].position) _indexOfCurrentPoint++;
        if (_indexOfCurrentPoint >= _movePoints.Length) _indexOfCurrentPoint = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.transform.SetParent(gameObject.transform);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.gameObject.transform.SetParent(null);
    }
}
