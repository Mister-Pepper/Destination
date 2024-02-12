using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string name;
    public int hp;

    public Player(string name)  // name will be passed in as an argument
    {
        this.hp = (int)Random.Range(10.0f, 20.0f);
        this.name = name;
    }

    public void display()
    {
        Debug.Log(this.name + " -> HP: " + this.hp);
    }

    public int getHp()
    {
        return this.hp;
    }

    public string getName()
    {
        return this.name;
    }

}
