using UnityEngine;

public class PlayerW9 : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private float _forwardSpeed = 7.0f;
    [SerializeField] private float _turnSpeed = 75.0f;

    // movement
    private void Update ()
    {
        float translation = Input.GetAxis("Vertical") * _forwardSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * _turnSpeed * Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if(Mathf.Abs(translation) > 0 || Mathf.Abs(rotation) > 0)
        {
            _animator.SetBool("IsMoving", true);
        }
        else
        {
            _animator.SetBool("IsMoving", false);
        }
    }
}