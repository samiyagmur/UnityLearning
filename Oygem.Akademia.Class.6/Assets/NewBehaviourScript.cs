using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/////////////////Part 1. Classes///////////////
//public class NewBehaviourScript : MonoBehaviour
//{
//    private void Start()
//    {   

//        //Animal animal= new Animal("Dog",10);

//        ////animal.age = 454;
//        ////animal.PrintAge();
//        //Animal animal1 = new Animal("Cat",15);//location canada

//        //Animal.location = "Turkey";
//        //animal.PrintAnimalInfo();//location turkey
//        //animal1.PrintAnimalInfo();

//        ////Classes1.value = 2;

//        //Classes1.Topla(14, 15);

//    }
//}

//public class Animal
//{
//    public int age;
//    public static string location = "Canada";
//    public string name;
//    public Animal()
//    {
//        Debug.Log("Animal Class reated");
//    }
//    public Animal(string _name ,int _age)
//    {
//        age= _age;
//        name= _name;
//    }
//    public void PrintAnimalInfo()
//    {
//        Debug.Log(name);
//        Debug.Log(age);
//        Debug.Log(location);

//    }
//}
//////////////////////Part 2. Struct//////////////
//public class NewBehaviourScript : MonoBehaviour
//{
//    private void Start()
//    {
//        AnimalStruct animalStruct;//nesnesi oluþturulamdan çaðýralabilir.

//        animalStruct.age = 15;//
//        animalStruct.name = "cat";


//    }
//}

//public struct AnimalStruct
//{
//    public string name;
//    public int age;

//    public AnimalStruct(string _name, int _age)
//    {
//        name = _name;
//        age = _age;
//    }
//    public void PrintAnimalInfo()
//    {
//        Debug.Log(name);
//        Debug.Log(age);
//    }
//}

//////////////Part 3. Enum////////////////
//public class NewBehaviourScript : MonoBehaviour
//{
//    public enum LevelDifficulty//The reason we wrote the Enum is to make the code understandable.
//    {
//        Easy=10,
//        Medium=20,
//        Hard=30
//    }
//    public enum CharacterState
//    {
//        Stopped,
//        WalkingForward,
//        WalkingBackward
//    }

//    public CharacterState characterState;
//    public float speed;

//    public int currentLevel;
//    private void Update()
//    {
//        if (currentLevel < (int)LevelDifficulty.Easy)
//        {
//            Debug.Log("Current level is easy");
//        }
//        else if (currentLevel < (int)LevelDifficulty.Medium)
//        {
//            Debug.Log("Current level is meidum");
//        }
//        else 
//        {
//            Debug.Log("Current level is hard");
//        }

//        //if(speed < 0)
//        //{
//        //    characterState = CharacterState.WalkingBackward;
//        //}
//        //else if(speed > 0)
//        //{
//        //    characterState=CharacterState.WalkingForward;
//        //}
//        //else
//        //{
//        //    characterState = CharacterState.Stopped;
//        //}



//    }
//}
////////////////Ýnheritance///////////////
public class NewBehaviourScript : MonoBehaviour
{
    private void Start()
    {
        Enemy normalEnemy=new Enemy();

        normalEnemy.Attack();
        normalEnemy.name = "NormalEnemy";
        normalEnemy.healt = 100;
        normalEnemy.PrintEnemyInfos();
        //normalEnemy.healt = 10;

        Orc orc1 = new Orc();
        orc1.name = "Orc";
        orc1.Walk();
        orc1.healt = 150;
        orc1.Attack();
        orc1.PrintEnemyInfos();

        Dragon dragon = new Dragon();
        dragon.name = "Dragon";
        dragon.healt = 450;
        dragon.Attack();
        dragon.Fly();
        dragon.PrintEnemyInfos();

        FireDragon fireDragon = new FireDragon();
        fireDragon.name = "Fire Dragon";
        fireDragon.healt = 600;
        fireDragon.Attack();
        fireDragon.Fly();
        fireDragon.TrowFire();
        fireDragon.PrintEnemyInfos();

    }
}

public class Enemy
{   
    public string name;
    public int healt;
    
    public void Attack()
    {
        //Debug.Log("Walk");
    }
    public void PrintEnemyInfos()
    {
        Debug.Log("Name:"+name+"Health:"+healt);
    }
}

public class Orc:Enemy
{
    public void Walk()
    {
        //Debug.Log("Walk");
    }
}

public class Dragon:Enemy
{
    public void Fly()
    {
        //Debug.Log("Fly ");

    }
}

public class FireDragon:Dragon
{
    public void TrowFire()
    {
        //Debug.Log("Throw Fire");
    }
}