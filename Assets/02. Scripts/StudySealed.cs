using UnityEngine;

public class StudySealed : MonoBehaviour
{
    public int number = 10;

    private const int NUMBER = 100;
}

public sealed class Monster123
{
    // 속성과 기능
}

public class Monster234
{
    public int hp;
    public int damage;

    public virtual void Attack()
    {
        // 몬스터 공격
    }
}

public class Orc : Monster234
{
    public sealed override void Attack()
    {
        // 오크의 도끼 공격
    }
}