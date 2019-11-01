using System.Collections;
using BindingsRx.Bindings;
using TMPro;
using UniRx;
using UnityEngine;

namespace BindingsRx.TMP
{
    public class PropertyToInputField : MonoBehaviour
    {
        [SerializeField] private TMP_InputField inputField;
        private readonly ReactiveProperty<int> _val = new ReactiveProperty<int>(0);

        private void Start()
        {
            inputField.BindTextTo(_val);
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
}
