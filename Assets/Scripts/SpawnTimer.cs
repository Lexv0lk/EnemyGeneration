using UnityEngine;

public class SpawnTimer : MonoBehaviour
{
    [SerializeField] private Spawner[] _spawners;
    [SerializeField] private float _delay = 2f;

    private float _passedTime;

    private void Start()
    {
        _passedTime = _delay;
    }

    private void Update()
    {
        _passedTime += Time.deltaTime;

        if (_passedTime >= _delay)
        {
            _spawners[Random.Range(0, _spawners.Length)].Spawn();
            _passedTime = 0;
        }
    }
}