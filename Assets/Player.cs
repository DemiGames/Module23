using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;
    public GameObject[] weapons;
    float mouseWheel;
    int count;
    void Update()
    {
        InputValues();
        ChangeWeapon();
    }
    void InputValues()
    {
        if (Input.GetKeyDown("1"))
            animator.SetTrigger("defeated");
        if (Input.GetKeyDown("2"))
            animator.SetTrigger("jump");
        if (Input.GetKeyDown(KeyCode.Alpha3))
            animator.SetTrigger("martelo");
        if (Input.GetKeyDown(KeyCode.Alpha4))
            animator.SetTrigger("rumba");
        if (Input.GetKeyDown(KeyCode.Alpha5))
            animator.SetTrigger("block");
    }
    void ChangeWeapon()
    {
        mouseWheel = Input.GetAxis("Mouse ScrollWheel");
        if (mouseWheel > 0 && count < 2)
            count++;
        else if (mouseWheel < 0 && count > 0)
            count--;
        for (int i = 0; i < weapons.Length; i++)
        {
            weapons[i].SetActive(false);
        }
        weapons[count].SetActive(true);
    }
}
