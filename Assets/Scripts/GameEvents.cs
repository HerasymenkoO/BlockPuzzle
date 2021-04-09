using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
    public static Action RequestNewShapes;
    public static Action CheckIfShapeCanBePlaced;
    public static Action MoveShapeToStartPositin;
    public static Action SetShapeInactive;
    public static Action<int> AddScores;
    public static Action<bool> GameOver;
}
