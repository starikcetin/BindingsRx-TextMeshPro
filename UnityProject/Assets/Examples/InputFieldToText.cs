using BindingsRx.TextMeshPro;
using TMPro;
using UnityEngine;

public class InputFieldToText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private TMP_InputField input;

    private void Start()
    {
        text.BindTextTo(() => input.text);
    }
}
