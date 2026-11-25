using TMPro;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private GameController _gameController;
    // Add member variables to store references to the Text Components for the
    //      various points texts.
    [SerializeField] private TMP_Text _commonText;
    [SerializeField] private TMP_Text _uncommonText;
    [SerializeField] private TMP_Text _rareText;
    [SerializeField] private TMP_Text _finalText;
    private string _itemString = "Final score: ";

    // ------------------------------------------------------------------------
    public void Activate(int commonPoints, int uncommonPoints, int rarePoints, int finalPoints)
    {
        gameObject.SetActive(true);

        // Update the points text with the final scores.
        _commonText.text = commonPoints.ToString();
        _uncommonText.text = uncommonPoints.ToString();
        _rareText.text = rarePoints.ToString();
        _finalText.text = _itemString + finalPoints;
    }

    // ------------------------------------------------------------------------
    // You don't need to code in this method :)
    public void RestartButton()
    {
        _gameController.RestartGame();
    }
}   
