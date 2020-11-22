using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Script_asset_create
{
    [MenuItem("Assets/Create ScriptableObject")]
    static void CreateScriptableObject()
    {
        Script_04_12 script = ScriptableObject.CreateInstance<Script_04_12>();
        script.playerInfos = new List<Script_04_12.PlayerInfo>();
        script.playerInfos.Add(new Script_04_12.PlayerInfo() { id = 1,name="haha"});
        AssetDatabase.CreateAsset(script, "Assets/Resources/Create Script_04_12.asset");
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();

    }
}
