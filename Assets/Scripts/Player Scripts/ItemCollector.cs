using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private TMP_Text m_Text;
    private int _coins = 0;

    private void FixedUpdate()
    {
        m_Text.text = "Золото: " + _coins;
    }
}
