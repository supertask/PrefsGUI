# PrefsGUI
Accessors and GUIs for persistent preference values using a JSON file

![](Documentation~/PrefsGUI.gif)

```csharp
// define PrefsParams with key.
public PrefsBool prefsBool = new PrefsBool("PrefsBool");
public PrefsInt prefsInt = new PrefsInt("PrefsInt");
public PrefsFloat prefsFloat = new PrefsFloat("PrefsFloat");
public PrefsString prefsString = new PrefsString("PrefsString");
public PrefsParam<EnumSample> prefsEnum = new PrefsParam<EnumSample>("PrefsEnum");
public PrefsColor prefsColor = new PrefsColor("PrefsColor");
public PrefsVector2 prefsVector2 = new PrefsVector2("PrefsVector2");
public PrefsVector3 prefsVector3 = new PrefsVector3("PrefsVector3");
public PrefsVector4 prefsVector4 = new PrefsVector4("PrefsVector4");
public PrefsAny<CustomClass> prefsClass = new PrefsAny<CustomClass>("PrefsClass");
public PrefsList<CustomClass> prefsList = new PrefsList<CustomClass>("PrefsList");


public void DoGUI()
{
    prefsBool.DoGUI();

    // Return true if value was changed
    var changed = prefsInt.DoGUI();
    if (changed)
    {
        // Implicitly convert
        int intValue = prefsInt;
        Debug.Log("Changed. " + intValue);
    }

    prefsFloat.DoGUI();
    prefsFloat.DoGUISlider();
    prefsString.DoGUI();
    prefsEnum.DoGUI();
    prefsColor.DoGUI();
    prefsVector2.DoGUI();
    prefsVector2.DoGUISlider();
    prefsVector3.DoGUI();
    prefsVector3.DoGUISlider();
    prefsVector4.DoGUI();
    prefsVector4.DoGUISlider();
    prefsClass.DoGUI();
    prefsList.DoGUI();
}
```

## Installation

This package uses the [scoped registry] feature to resolve package dependencies. 

[scoped registry]: https://docs.unity3d.com/Manual/upm-scoped.html


**Edit > ProjectSettings... > Package Manager > Scoped Registries**

Enter the following and click the Save button.

```
"name": "fuqunaga",
"url": "https://registry.npmjs.com",
"scopes": [ "ga.fuquna" ]
```
![](Documentation~/2022-04-12-17-29-38.png)


**Window > Package Manager**

Select `MyRegistries` in `Packages:`

![](Documentation~/2022-04-12-17-40-26.png)

Install `PrefsGUI - RosettaUI` and `RosettaUI - UIToolkit`  
If you prefer IMGUI, please select `PrefsGUI - RapidGUI` instead.

![](Documentation~/2022-04-21-17-00-54.png)

If you do not see it, please make sure that your Unity version is 2021.3 or higher.


## PrefsSearch

![](Documentation~/PrefsSearch.gif)

Display loaded PrefsParams with partial key match


## EditorWindow

![](Documentation~/PrefsGUIEditor.gif)
- **Window -> PrefsGUI**
- Display all loaded prefs that can be modified
- You can also feed back the current value as a default value
- You can edit the key prefix for each GameObject by displaying it in order of GameObject

### JSON file path
```
Application.persistentDataPath + "/Prefs.json"
```

You can customize it by placing PrefsWrapperPathCustom in the scene and setting the `_path` field.
Special folder names and environment variables are also available.
```
- %dataPath% -> Application.dataPath
- %companyName% -> Application.companyName
- %productName% -> Application.productName
- other %[word]% -> System.Environment.GetEnvironmentVariable([word])
```


## MaterialPropertyDebugMenu

Auto-create material GUI menu

![](Documentation~/MaterialPropertyDebugMenu.gif)


## Sync Prefs over a network

**PrefsGUISyncUNET**
https://github.com/fuqunaga/PrefsGUISyncUNET


## References

- **RapidGUI**
https://github.com/fuqunaga/RapidGUI
- **PrefsGUISyncUNET**
https://github.com/fuqunaga/PrefsGUISyncUNET
