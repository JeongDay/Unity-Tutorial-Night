using UnityEngine;

[CreateAssetMenu(fileName = "NewScriptableObjectScript", menuName = "Scriptable Objects/NewScriptableObjectScript")]
public class PlayerData : ScriptableObject
{
    public int playerDamage;
    public int playerHealth;
    public DetailData detailData;
}

public class DetailData
{
    public int playerLevel;
    public string playerName;
    public string playerClan;
}