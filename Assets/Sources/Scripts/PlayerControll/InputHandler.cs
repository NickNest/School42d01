using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private new GameObject[] gameObject;
    private int _playerChoice = 0;
    private void Start()
    {
        Actions.PlayerChoiceOfCharacter += OnPlayerChoice;
    }
    private void OnPlayerChoice(int choice)
    {
        _playerChoice = choice;
    }

    private void FixedUpdate()
    {
        if (gameObject[_playerChoice].TryGetComponent(out IMovable movable) && Input.GetAxisRaw("Horizontal") != 0)
            movable.Move(Input.GetAxisRaw("Horizontal"));
    }
    void Update()
    {
        if (gameObject[_playerChoice].TryGetComponent(out IJumpable jumpable) && Input.GetKeyDown(KeyCode.Space))
            jumpable.Jump();
    }

}
