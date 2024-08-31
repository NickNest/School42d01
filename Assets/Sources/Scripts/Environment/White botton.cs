using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class WhiteButton : MonoBehaviour
{

    private void OnTriggerStay2D(Collider2D collision)
    {
        Actions.OnBottonPressed(collision.gameObject.tag, true);
        transform.localScale = new Vector3(0.2f, 0.1f / 5, 1);

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Actions.OnBottonPressed(collision.gameObject.tag, false);
        transform.localScale = new Vector3(0.2f, 0.1f, 1);
    }
}
