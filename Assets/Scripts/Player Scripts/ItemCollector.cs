using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private TMP_Text m_Text;
    private int _coins = 0;

    private void FixedUpdate()
    {
<<<<<<< HEAD
        
        m_Text.text = "ְנבאיעום";
=======
        m_Text.text = "ַמכמעמ: " + _coins;
>>>>>>> 7a549ad2f3e6e011521d5e816bf1f6638f934db9
    }
}
