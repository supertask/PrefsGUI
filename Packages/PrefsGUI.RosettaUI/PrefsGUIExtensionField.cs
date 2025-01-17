using RosettaUI;
using UnityEngine;

namespace PrefsGUI.RosettaUI
{
    public static class PrefsGUIExtensionField
    {
        public static Element CreateElement<T>(this PrefsParamOuter<T> prefs, LabelElement label = null)
        {
            return UI.Row(
                UI.Field(
                    label ?? prefs.key,
                    prefs.Get,
                    prefs.Set
                ),
                prefs.CreateDefaultButtonElement()
            );
        }

        public static Element CreateElement<TPrefs0, TPrefs1, TOuter0, TOuter1>(
            this PrefsSet<TPrefs0, TPrefs1, TOuter0, TOuter1> prefs)
            where TPrefs0 : PrefsParamOuter<TOuter0>
            where TPrefs1 : PrefsParamOuter<TOuter1>
        {
            return UI.Fold(
                prefs.key,
                prefs.prefs0.CreateElement(),
                prefs.prefs1.CreateElement()
            );
        }
    }
}