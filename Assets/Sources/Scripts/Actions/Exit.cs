using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(BoxCollider2D))]
public class Exit : MonoBehaviour
{
    private static int _numOfEntryObjects = 0;

    private void Update()
    {
        if (_numOfEntryObjects == 3)
        {
            var index = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(index + 1);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == this.gameObject.tag)
        {
            _numOfEntryObjects++;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == this.gameObject.tag)
        {
            _numOfEntryObjects--;
        }
    }
}
