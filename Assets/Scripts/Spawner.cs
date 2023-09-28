using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SimpleMover _template;

    public void Spawn()
    {
        SimpleMover mover = Instantiate(_template, transform.position, Quaternion.identity);

        mover.StartMoving(transform.forward);
    }
}