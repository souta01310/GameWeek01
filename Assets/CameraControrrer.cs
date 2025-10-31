using UnityEngine;

public class CameraController : MonoBehaviour
{
    float rotationSpeed = 2.0f;
    float mouse_X;
    float mouse_Y;
    public GameObject player;   // �v���C���[�I�u�W�F�N�g�̕ϐ�

    void Update()
    {
        // �}�E�X���N���b�N�����ꍇ
        if (Input.GetMouseButton(0))
        {
            mouse_X = Input.GetAxis("Mouse X") * rotationSpeed;
            mouse_Y = Input.GetAxis("Mouse Y") * rotationSpeed;
            transform.RotateAround(player.transform.position, Vector3.up, mouse_X); // Y���ɑ΂��ĉ�]�����鏈��
            transform.RotateAround(player.transform.position, transform.right, mouse_Y); // X���ɑ΂��ĉ�]�����鏈��
        }
    }
}
