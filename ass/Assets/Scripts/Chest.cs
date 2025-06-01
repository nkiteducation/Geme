using UnityEngine;

public class Chest : MonoBehaviour
{
    private readonly int OpenTrigger = Animator.StringToHash("Open");
    [SerializeField] private Animator _animator;

    public void OpenChest()
    {
        _animator.SetTrigger(OpenTrigger);
    }
}
