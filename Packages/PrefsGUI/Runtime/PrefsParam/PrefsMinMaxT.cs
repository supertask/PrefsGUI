﻿using RapidGUI;

namespace PrefsGUI
{
    public abstract class PrefsMinMax<T, TMinMax> : PrefsAny<TMinMax>, IPrefsSlider<T>   
        where TMinMax : MinMax<T>, new()
    {
        public T min => Get().min;
        public T max => Get().max;

        public PrefsMinMax(string key, T defaultValueMax = default) : this(key, default, defaultValueMax) { }
        public PrefsMinMax(string key, T defaultValueMin,  T defaultValueMax) : base(key, new TMinMax() { min = defaultValueMin, max = defaultValueMax }) { }


        #region IPrefSlider

        public abstract T defaultMin { get; }

        public abstract T defaultMax { get; }

        public bool DoGUISlider(T rangeMin, T rangeMax, string label = null)
        {
            return DoGUIStrandard((v) =>
            {
                RGUI.MinMaxSlider(ref v.min, ref v.max, rangeMin, rangeMax, label ?? key);
                return v;
            });
        }

        #endregion
    }
}