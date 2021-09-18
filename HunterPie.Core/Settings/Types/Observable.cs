﻿using Newtonsoft.Json;

namespace HunterPie.Core.Settings.Types
{
    public class Observable<T> : ObservableBase
    {
        private T _value;

        [JsonProperty]
        public T Value
        {
            get => _value;
            set { SetValue(ref _value, value); }
        }

        [JsonConstructor]
        public Observable(T value)
        {
            Value = value;
        }

        public static implicit operator Observable<T>(T v)
        {
            return new Observable<T>(v);
        }

        public static Observable<T> Default()
        {
            return new Observable<T>(default);
        }
    }
}