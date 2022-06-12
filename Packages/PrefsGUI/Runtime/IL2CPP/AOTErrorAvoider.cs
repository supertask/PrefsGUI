using System;
using System.Collections.Generic;
using UnityEngine;


namespace PrefsGUI.IL2CPP
{
    public static class AOTErrorAvoider
    { 
        public static void CompileHint()
        {
            new JsonUtilityEx.ValueWrapper<bool>(false);
            new JsonUtilityEx.ValueWrapper<int>(0);
            new JsonUtilityEx.ValueWrapper<float>(0);
            new JsonUtilityEx.ValueWrapper<string>("");
            new JsonUtilityEx.ValueWrapper<Vector2>(Vector2.zero);
            new JsonUtilityEx.ValueWrapper<Vector3>(Vector3.zero);
            new JsonUtilityEx.ValueWrapper<Vector3>(Vector4.zero);
            new JsonUtilityEx.ValueWrapper<Vector2Int>(Vector2Int.zero);
            new JsonUtilityEx.ValueWrapper<Vector3Int>(Vector3Int.zero);
            new JsonUtilityEx.ValueWrapper<Color>(Color.black);
        }
    
    }
}