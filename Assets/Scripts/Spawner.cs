using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Chaser _template;
    [SerializeField] private Transform _target;

    public void Spawn()
    {
        Chaser mover = Instantiate(_template, transform.position, Quaternion.identity);

        mover.StartChasing(_target);
    }
}