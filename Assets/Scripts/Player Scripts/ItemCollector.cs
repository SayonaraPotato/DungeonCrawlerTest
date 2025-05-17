using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private TMP_Text m_Text;

    private void FixedUpdate()
    {
        m_Text.text = "Арбайтен";
    }
}
