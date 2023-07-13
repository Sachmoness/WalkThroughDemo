using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float xDirec, zDirec;

    public CharacterController charController;

    [SerializeField]
    private float _movementSpeed = 10f;

    void Start()
    {
        
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

        charController.Move(moveDirec * _movementSpeed * Time.deltaTime);
    }
}
