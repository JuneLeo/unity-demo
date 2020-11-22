using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Script_04_12 : ScriptableObject
{
    [SerializeField]
    public List<PlayerInfo> playerInfos;

    [System.Serializable]
    public class PlayerInfo
    {
        public int id;
        public string name;
    }
}
