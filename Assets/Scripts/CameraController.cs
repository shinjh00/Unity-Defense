using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float padding;

    private Vector3 moveDir;

    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    private void OnDisable()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(moveDir * moveSpeed * Time.deltaTime, Space.World);
    }

    private void OnMove(InputValue value)
    {
        Vector2 inputDir = value.Get<Vector2>();
        moveDir.x = inputDir.x;
        moveDir.z = inputDir.y;
    }
    
    private void OnPointer(InputValue value)
    {
        Vector2 inputDir = value.Get<Vector2>();
        Debug.Log(inputDir);

        if (inputDir.x < padding)
        {
            moveDir.x = -1;
        }
        else if (inputDir.x > Screen.width - padding)  // (�ػ� - padding) ���� Ŭ ��
        {
            moveDir.x = 1;
        }
        else if (inputDir.y < padding)
        {
            moveDir.z = -1;
        }
        else if (inputDir.y > Screen.height - padding)
        {
            moveDir.z = 1;
        }
        else
        {
            // padding ���� ����� �� �� �����̰�
            moveDir.x = 0;
            moveDir.z = 0;
        }
    }
}
