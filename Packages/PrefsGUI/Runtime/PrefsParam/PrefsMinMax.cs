﻿namespace PrefsGUI
{
    public abstract class PrefsMinMax<T> : PrefsAny<PrefsMinMax<T>.MinMax>, IPrefsSlider<T>   
    {
        public class MinMax
        {
            public T min;
            public T max;
        }
        
        public T min => Get().min;
        public T max => Get().max;

        public PrefsMinMax(string key, T defaultValueMax = default) : this(key, default, defaultValueMax) { }
        public PrefsMinMax(string key, T defaultValueMin,  T defaultValueMax) : base(key, new MinMax() { min = defaultValueMin, max = defaultValueMax }) { }


        #region IPrefSlider

        public abstract T defaultMin { get; }

        public abstract T defaultMax { get; }
        
        #endregion
    }
}