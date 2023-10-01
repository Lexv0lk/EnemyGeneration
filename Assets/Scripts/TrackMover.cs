using UnityEngine;

public class TrackMover : MonoBehaviour
{
    [SerializeField] private Transform[] _track;
    [SerializeField] private float _speed;

    private int _currentPointIndex = 0;

    private void Update()
    {
        Vector3 currentPointPosition = _track[_currentPointIndex].position;
        transform.position = Vector3.MoveTowards(transform.position, currentPointPosition, _speed * Time.deltaTime);

        if (transform.position == currentPointPosition)
            PickNextPoint();
    }

    private void PickNextPoint()
    {
        int nextPointIndex = (_currentPointIndex + 1) % _track.Length;
        _currentPointIndex = nextPointIndex;
    }
}