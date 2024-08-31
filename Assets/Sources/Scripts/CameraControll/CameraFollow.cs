using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform[] _transformsOfObjects;
    [SerializeField] private int _speedOfCamera = 5;
    private int _currentChar = 0;

    private void Start()
    {
        Actions.PlayerChoiceOfCharacter += OnPlayerChoice;
    }
    private void OnPlayerChoice(int choice)
    {
        _currentChar = choice;
    }

    void FixedUpdate()
    {
        transform.position = 
            Vector3.Lerp(transform.position, 
            new Vector3(_transformsOfObjects[_currentChar].position.x, _transformsOfObjects[_currentChar].position.y, -2), 
            Time.deltaTime * _speedOfCamera);
    }
}
