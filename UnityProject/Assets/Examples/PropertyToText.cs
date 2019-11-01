using System.Collections;
using BindingsRx.TMP;
using TMPro;
using UniRx;
using UnityEngine;

public class PropertyToText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    private readonly ReactiveProperty<int> _val = new ReactiveProperty<int>(0);

    private void Start()
    {
        text.BindTextTo(_val);
        StartCoroutine(nameof(Inc));
    }

    private IEnumerator Inc()
    {
        while (true)
        {
            _val.Value += 1;
            yield return new WaitForSeconds(1);
        }
    }
}
