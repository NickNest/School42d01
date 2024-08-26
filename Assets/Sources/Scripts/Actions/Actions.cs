using System;

public class Actions
{
    public static event Action<int> PlayerChoiceOfCharacter;
    public static void OnPlayerChoice(int choice)
    {
        PlayerChoiceOfCharacter?.Invoke(choice);
    }

}
