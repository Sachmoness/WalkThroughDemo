using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float xDirec, zDirec;

    private CharacterController _charController;

    [SerializeField]
    private float _movementSpeed = 10f;

    void Start()
    {
        _charController = GetComponent<CharacterController>();
    }

    void Update()
    {
        PlayerInput();
        Move();
    }

    void PlayerInput()
    {
        xDirec = Input.GetAxis("Horizontal");
        zDirec = Input.GetAxis("Vertical");
    }

    void Move(){
        Vector3 moveDirec = transform.right * xDirec + transform.forward * zDirec;

        _charController.Move(moveDirec * _movementSpeed * Time.deltaTime);
    }
}
