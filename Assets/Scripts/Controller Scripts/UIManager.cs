using System.Xml.Serialization;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _uiText;

    private void Update()
    {
        _uiText.SetText("Количество монет: " + ScoreManager._scoreManager.GetCoinsScore());
    }
}
