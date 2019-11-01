using System;
using BindingsRx.Bindings;
using BindingsRx.Converters;
using BindingsRx.Filters;
using TMPro;
using UniRx;
using UnityEngine;

namespace BindingsRx.TextMeshPro
{
    public static class TMP_InputFieldExtensions
    {
        public static IDisposable BindTextTo(this TMP_InputField input, IReactiveProperty<string> property,
            BindingTypes bindingType = BindingTypes.Default, params IFilter<string>[] filters)
        {
            return GenericBindings.Bind(() => input.text, x => input.text = x, property, bindingType, filters)
                .AddTo(input);
        }

        public static IDisposable BindTextTo(this TMP_InputField input, IReactiveProperty<int> property,
            BindingTypes bindingType = BindingTypes.Default, params IFilter<string>[] filters)
        {
            return GenericBindings.Bind(() => input.text, x => input.text = x, property, new TextToIntConverter(),
                bindingType, filters).AddTo(input);
        }

        public static IDisposable BindTextTo(this TMP_InputField input, IReactiveProperty<float> property,
            BindingTypes bindingType = BindingTypes.Default, params IFilter<string>[] filters)
        {
            return GenericBindings.Bind(() => input.text, x => input.text = x, property, new TextToFloatConverter(),
                bindingType, filters).AddTo(input);
        }

        public static IDisposable BindTextTo(this TMP_InputField input, IReactiveProperty<double> property,
            BindingTypes bindingType = BindingTypes.Default, params IFilter<string>[] filters)
        {
            return GenericBindings.Bind(() => input.text, x => input.text = x, property, new TextToDoubleConverter(),
                bindingType, filters).AddTo(input);
        }

        public static IDisposable BindTextTo(this TMP_InputField input, Func<string> getter, Action<string> setter,
            BindingTypes bindingType = BindingTypes.Default, params IFilter<string>[] filters)
        {
            return GenericBindings.Bind(() => input.text, x => input.text = x, getter, setter, bindingType, filters)
                .AddTo(input);
        }

        public static IDisposable BindCaretColorTo(this TMP_InputField input, IReactiveProperty<Color> property,
            BindingTypes bindingType = BindingTypes.Default, params IFilter<Color>[] filters)
        {
            return GenericBindings
                .Bind(() => input.caretColor, x => input.caretColor = x, property, bindingType, filters).AddTo(input);
        }

        public static IDisposable BindCaretColorTo(this TMP_InputField input, Func<Color> getter, Action<Color> setter,
            BindingTypes bindingType = BindingTypes.Default, params IFilter<Color>[] filters)
        {
            return GenericBindings
                .Bind(() => input.caretColor, x => input.caretColor = x, getter, setter, bindingType, filters)
                .AddTo(input);
        }

        public static IDisposable BindColorTo(this TMP_InputField input, IReactiveProperty<Color> property,
            BindingTypes bindingType = BindingTypes.Default, params IFilter<Color>[] filters)
        {
            return input.textComponent.BindColorTo(property, bindingType, filters).AddTo(input);
        }

        public static IDisposable BindColorTo(this TMP_InputField input, Func<Color> getter, Action<Color> setter,
            BindingTypes bindingType = BindingTypes.Default, params IFilter<Color>[] filters)
        {
            return input.textComponent.BindColorTo(getter, setter, bindingType, filters).AddTo(input);
        }
    }
}
