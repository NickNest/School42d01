using UnityEngine;

public class ChoicerOfCharacter : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) Actions.OnPlayerChoice(0);
        else if (Input.GetKeyDown(KeyCode.Alpha2)) Actions.OnPlayerChoice(1);
        else if (Input.GetKeyDown(KeyCode.Alpha3)) Actions.OnPlayerChoice(2);
    }
}
