using UnityEngine;

public interface IAttack
{
    int damage { get; set; }

    void Use();
}