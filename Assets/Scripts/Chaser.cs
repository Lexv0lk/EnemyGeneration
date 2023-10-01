using UnityEngine;

public class Chaser : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;

    private Transform _currentTarget;

    public void StartChasing(Transform target)
    {
        _currentTarget = target;
    }

    private void Update()
    {
        if (_currentTarget == null)
            return;

        transform.position = Vector3.MoveTowards(transform.position, _currentTarget.position, _speed * Time.deltaTime);
    }
}