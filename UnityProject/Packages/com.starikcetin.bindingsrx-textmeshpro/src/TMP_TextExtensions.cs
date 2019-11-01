using System;
using BindingsRx.Bindings;
using BindingsRx.Converters;
using BindingsRx.Filters;
using TMPro;
using UniRx;
using UnityEngine;

namespace BindingsRx.TMP
{
    public static class TMP_TextExtensions
    {
        public static IDisposable BindTextTo(this TMP_Text input, IReadOnlyReactiveProperty<string> property, 
            params IFilter<string>[] filters)
        {
            return GenericBindings.Bind(x => input.text = x, property, filters).AddTo(input);
        }

        public static IDisposable BindTextTo(this TMP_Text input, IReactiveProperty<string> property,
            params IFilter<string>[] filters)
        {
            return GenericBindings.Bind(() => input.text, x => input.text = x, property, BindingTypes.OneWay, filters)
                .AddTo(input);
        }

        public static IDisposable BindTextTo(this TMP_Text input, IReactiveProperty<int> property,
            params IFilter<string>[] filters)
        {
            return GenericBindings.Bind(() => input.text, x => input.text = x, property, new TextToIntConverter(),
                BindingTypes.OneWay, filters).AddTo(input);
        }

        public static IDisposable BindTextTo(this TMP_Text input, IReactiveProperty<float> property,
            params IFilter<string>[] filters)
        {
            return GenericBindings.Bind(() => input.text, x => input.text = x, property, new TextToFloatConverter(),
                BindingTypes.OneWay, filters).AddTo(input);
        }

        public static IDisposable BindTextTo(this TMP_Text input, IReactiveProperty<double> property,
            params IFilter<string>[] filters)
        {
            return GenericBindings.Bind(() => input.text, x => input.text = x, property, new TextToDoubleConverter(),
                BindingTypes.OneWay, filters).AddTo(input);
        }

        public static IDisposable BindTextTo(this TMP_Text input, IReactiveProperty<DateTime> property,
            string dateTimeFormat = "d", params IFilter<string>[] filters)
        {
            return GenericBindings.Bind(() => input.text, x => input.text = x, property,
                new TextToDateConverter(dateTimeFormat), BindingTypes.OneWay, filters).AddTo(input);
        }

        public static IDisposable BindTextTo(this TMP_Text input, IReactiveProperty<TimeSpan> property,
            params IFilter<string>[] filters)
        {
            return GenericBindings.Bind(() => input.text, x => input.text = x, property, new TextToTimeSpanConverter(),
                BindingTypes.OneWay, filters).AddTo(input);
        }

        public static IDisposable BindTextTo<T>(this TMP_Text input, IReactiveProperty<T> property,
            IConverter<string, T> converter, params IFilter<string>[] filters)
        {
            return GenericBindings.Bind(() => input.text, x => input.text = x, property, converter, BindingTypes.OneWay,
                filters).AddTo(input);
        }

        public static IDisposable BindTextTo(this TMP_Text input, Func<string> getter,
            params IFilter<string>[] filters)
        {
            return GenericBindings
                .Bind(() => input.text, x => input.text = x, getter, null, BindingTypes.OneWay, filters).AddTo(input);
        }

        public static IDisposable BindTextTo<T>(this TMP_Text input, Func<T> getter,
            IConverter<string, T> converter,
            params IFilter<string>[] filters)
        {
            return GenericBindings.Bind(() => input.text, x => input.text = x, getter, null, converter,
                BindingTypes.OneWay, filters).AddTo(input);
        }

        public static IDisposable BindFontSizeTo(this TMP_Text input, IReactiveProperty<float> property,
            params IFilter<float>[] filters)
        {
            return GenericBindings
                .Bind(() => input.fontSize, x => input.fontSize = x, property, BindingTypes.OneWay, filters)
                .AddTo(input);
        }

        public static IDisposable BindFontSizeTo(this TMP_Text input,
            IReadOnlyReactiveProperty<float> property,
            params IFilter<float>[] filters)
        {
            return GenericBindings.Bind(x => input.fontSize = x, property, filters).AddTo(input);
        }

        public static IDisposable BindFontSizeTo(this TMP_Text input, Func<float> getter,
            params IFilter<float>[] filters)
        {
            return GenericBindings.Bind(() => input.fontSize, x => input.fontSize = x, getter, null,
                BindingTypes.OneWay, filters).AddTo(input);
        }

        public static IDisposable BindColorTo(this TMP_Text input, IReactiveProperty<Color> property,
            BindingTypes bindingType = BindingTypes.Default, params IFilter<Color>[] filters)
        {
            return GenericBindings.Bind(() => input.color, x => input.color = x, property, bindingType, filters)
                .AddTo(input);
        }

        public static IDisposable BindColorTo(this TMP_Text input, IReadOnlyReactiveProperty<Color> property,
            params IFilter<Color>[] filters)
        {
            return GenericBindings.Bind(x => input.color = x, property, filters).AddTo(input);
        }

        public static IDisposable BindColorTo(this TMP_Text input, Func<Color> getter, Action<Color> setter,
            BindingTypes bindingType = BindingTypes.Default, params IFilter<Color>[] filters)
        {
            return GenericBindings.Bind(() => input.color, x => input.color = x, getter, setter, bindingType, filters)
                .AddTo(input);
        }
    }
}
