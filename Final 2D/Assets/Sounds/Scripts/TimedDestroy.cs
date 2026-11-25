using UnityEngine;

public class TimedDestroy : MonoBehaviour
{
    [SerializeField] private float _lifetime = 1f;

    private void Start()
    {
        Destroy(gameObject, _lifetime);
    }
}
// Write a timer that destroys the gameobject it's attached to when time is up.
// Use this to remove your explosion VFX when they're done playing.

