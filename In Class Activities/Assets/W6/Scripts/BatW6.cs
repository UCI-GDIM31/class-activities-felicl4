using UnityEngine;
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    private Transform _playerTransform;

    void Awake() { enabled = false; }              // start off

    public void EnableChase(Transform player)
    {
        _playerTransform = player;                 // set target FIRST
        enabled = true;                            // then allow Update to run
    }

    public void DisableChase()
    {
        enabled = false;
        _playerTransform = null;
    }

    void Update()
    {
        if (_playerTransform == null) return;      // safety guard
        transform.position = Vector3.MoveTowards(
            transform.position, _playerTransform.position, _speed * Time.deltaTime);
    }
}
