using UnityEngine;

public class Player : MonoBehaviour
{
    public IAttack current_having_Weapon;
    
    private bool isHaving = false;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 왼쪽 마우스 클릭
        {
            current_having_Weapon.Use();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<IAttack>() != null)
        {
            current_having_Weapon = other.GetComponent<IAttack>();
            isHaving = true;
        }
    }
}