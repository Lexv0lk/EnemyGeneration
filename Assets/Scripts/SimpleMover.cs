using UnityEngine;

public class SimpleMover : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;

    private Vector3 _currentDirection = Vector3.zero;

    public void StartMoving(Vector3 direction)
    {
        _currentDirection = direction;
    }

    private void Update()
    {
        if (_currentDirection == Vector3.zero)
            return;

        transform.Translate(_speed * Time.deltaTime * _currentDirection.normalized); 
    }
}