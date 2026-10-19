using UnityEngine;

[CreateAssetMenu(fileName = "Ability", menuName = "Scriptable Objects/Ability")]
public abstract class Ability : ScriptableObject
{
    public abstract void useAbility();
}
