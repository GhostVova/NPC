using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcController : MonoBehaviour
{
    //назначиваем переменную жизней NPC
    public int health = 7;

    //назначаем переменную уровня NPC
    public int level = 1;
    
    //назначаем дробную переменную скорости NPC
    public float speed = 1.7f;

    void Start()
    {
        health = health + level;
        print("Жизней NPC:" + health);
    }

    void Update()
    {
        //создаём переменную Vector3, в которой сохраняем позицию персонажа.
        Vector3 newPosition = transform.position;

        //двигаем NPC по оси Z
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
