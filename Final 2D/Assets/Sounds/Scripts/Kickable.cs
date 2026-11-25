using UnityEngine;

// Add an enum to represent an item's rarity.
public enum Rarity
{
    Common,
    Uncommon,
    Rare
}
public class Kickable : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private GameObject _explosionVfxPrefab;
    // Add a member variable to represent this item's rarity.
    [SerializeField] private Rarity _rarity;
    private bool _wasKicked;
    private GameController _gameController;

    // ------------------------------------------------------------------------
    // You don't need to code in this method :)
    private void Start ()
    {
        _gameController = GameObject.FindFirstObjectByType<GameController>();
    }

    // ------------------------------------------------------------------------
    public void Kick(Vector3 force)
    {
        if (_wasKicked) return;
        _wasKicked = true;
        _rigidbody.AddForce(force, ForceMode2D.Impulse);
        _gameController.Kicked(gameObject,_rarity);

        // Let the GameController know this object was kicked.
    }

    // ------------------------------------------------------------------------
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (_wasKicked)
        {
            Explode();
        }
    }

    // ------------------------------------------------------------------------
    private void Explode()
    {
        // Create the explosion VFX.
        Instantiate(_explosionVfxPrefab,

        transform.position,

        Quaternion.identity);

        Destroy(gameObject);

    }
    // Destroy this item.
}

