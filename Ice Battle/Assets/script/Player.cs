using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    new String name; 
    int score;

    public Player(String n) {
        name = n;
        score = 0;
    }

    String getName() { return name; }
    int getScore() { return score; }

}
