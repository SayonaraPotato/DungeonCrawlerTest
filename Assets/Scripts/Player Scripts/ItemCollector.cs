using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private TMP_Text m_Text;
    private int _coins = 0;

    private void FixedUpdate()
    {
<<<<<<< HEAD
        
        m_Text.text = "��������";
=======
        m_Text.text = "������: " + _coins;
>>>>>>> 7a549ad2f3e6e011521d5e816bf1f6638f934db9
    }
}
