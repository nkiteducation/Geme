using UnityEngine;

public class ChestOpenTrigger : MonoBehaviour
{
    [SerializeField] private Chest _chest;

    private bool _isOpen = false;
    private bool _hasOpened;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<ChestOpener>())
        {
            _hasOpened = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<ChestOpener>())
        {
            _hasOpened = false;
        }
    }

    private void Update()
    {
        if (_isOpen)
        {
            return;
        }
        if (_hasOpened && Input.GetKeyDown(KeyCode.E))
        {
            _chest.OpenChest();
            _isOpen = true;
        }
    }
}