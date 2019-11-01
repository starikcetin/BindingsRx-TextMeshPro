using System.Collections;
using BindingsRx.TextMeshPro;
using TMPro;
using UniRx;
using UnityEngine;

public class CollectionToDropdown : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown dropdown;
    private readonly ReactiveCollection<string> _col = new ReactiveCollection<string>();
    private int _val = 0;

    private void Start()
    {
        dropdown.BindOptionsTo(_col);
        StartCoroutine(nameof(Inc));
    }

    private IEnumerator Inc()
    {
        while (true)
        {
            _val += 1;
            _col.Add(_val.ToString());
            yield return new WaitForSeconds(1);
        }
    }
}
