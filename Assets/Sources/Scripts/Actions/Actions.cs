using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Actions
{
    public static event Action<int> PlayerChoiceOfCharacter;
    public static void OnPlayerChoice(int choice)
    {
        PlayerChoiceOfCharacter?.Invoke(choice);
    }

}
