using System.Reflection;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float walkSpeed = 4f;     // �ʏ�ړ����x
    [SerializeField] private float runSpeed = 8f;      // ���鑬�x
    [SerializeField] private string targetTag;         //�^�O
    [SerializeField] private GameObject UI;�@�@�@�@�@�@//ui�v���n�u
    private string methodName = "OnHit";�@�@�@�@�@�@�@ //�Ăяo���֐���

    private void Start()
    {
        UI.SetActive(false);
    }
    void Update()
    {
        float Speed = walkSpeed;

        // W�L�[�i�O���ړ��j
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Speed = runSpeed;
            }
            transform.position += Speed * transform.forward * Time.deltaTime;
        }

        // S�L�[�i����ړ��j
        if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Speed = runSpeed;
            }
            transform.position -= Speed * transform.forward * Time.deltaTime;
        }

        // D�L�[�i�E�ړ��j
        if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Speed = runSpeed;
            }
            transform.position += Speed * transform.right * Time.deltaTime;
        }

        // A�L�[�i���ړ��j
        if (Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Speed = runSpeed;
            }
            transform.position -= Speed * transform.right * Time.deltaTime;
        }
    }

    //Ui�Ăяo��
    public void OnHit()
    {
        UI.SetActive(true);
    }

    //�p�[�e�B�N���̏Փ˔���
    private void OnParticleCollision(GameObject obj)
    {
        if (obj.gameObject.tag == "arrow")
        {
            SendMessage(methodName, SendMessageOptions.DontRequireReceiver);
        }
    }
}
