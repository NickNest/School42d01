using System;
using TMPro;

public class Actions
{
    public static event Action<int> PlayerChoiceOfCharacter;
    public static event Action<TagAttribute> PlayerExit;
    public static event Action<string, bool> BottonPressed;
    public static void OnPlayerChoice(int choice)
    {
        PlayerChoiceOfCharacter?.Invoke(choice);
    }
    public static void OnPlayerExit(TagAttribute tag)
    {
        PlayerExit?.Invoke(tag);
    }
    public static void OnBottonPressed(string tag, bool isPressed)
    {
        BottonPressed?.Invoke(tag, isPressed);
    }

}
