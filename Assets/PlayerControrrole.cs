using UnityEngine;

public class PlayerControrrole : MonoBehaviour
{
    [SerializeField] float PlayerMoveSpeed = 2.0f;
    [SerializeField] float PlayerBackSpeed = 1.0f;
    [SerializeField] float PlayerJumpPower = 5.0f;
    private bool _isGrounded;

    void Start()
    {
        _isGrounded = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += PlayerMoveSpeed * transform.forward * Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            int n = 0;
            transform.Rotate(new Vector3(0, ++n, 0)); 
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            int m = 90;
            transform.Rotate(new Vector3(0, --m, 0));
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += PlayerBackSpeed * transform.forward * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_isGrounded == false)
            {

            }
        }
    }
}
