using UnityEngine;

public class DoorController : MonoBehaviour
{
    private void Start()
    {
        Actions.BottonPressed += OnBottonPressed;
    }

    private void OnDestroy()
    {
        Actions.BottonPressed -= OnBottonPressed;
    }

    public void OnBottonPressed(string tag, bool isPressed)
    {
        if (tag == gameObject?.tag)
        {
            if (isPressed) gameObject?.SetActive(false);
            else gameObject?.SetActive(true);
        }
        
    }
}
