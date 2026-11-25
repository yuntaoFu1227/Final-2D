using UnityEngine;
using UnityEngine.UI;

public class ChecklistItemUI : MonoBehaviour
{
    [SerializeField] private Image _itemImage;
    [SerializeField] private Image _checkImage;
    [SerializeField] private Sprite _filledCheckSprite;

    public GameObject _requiredItem;

    // ------------------------------------------------------------------------
    public void SetItem (GameObject itemObject)
    {
        // Store the required itemObject in _requiredItem.
        _requiredItem = itemObject;
        _itemImage.sprite = itemObject.GetComponent<SpriteRenderer>().sprite;
    // Change our item sprite to the itemObject's SpriteRenderer's sprite.

    }

    // ------------------------------------------------------------------------
    public void FoundItem ()
    {
        _checkImage.sprite = _filledCheckSprite;

    }
    // Change our checkbox sprite to the filled checkbox version.
}

