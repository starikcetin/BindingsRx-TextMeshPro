using BindingsRx.TextMeshPro;
using TMPro;
using UnityEngine;

public class DropdownToDropdown : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown source;
    [SerializeField] private TMP_Dropdown target;

    private void Start()
    {
        target.BindValueTo(() => source.value, i => source.value = i);
    }
}
