using System.Reflection;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float walkSpeed = 4f;     // 通常移動速度
    [SerializeField] private float runSpeed = 8f;      // 走る速度
    [SerializeField] private string targetTag;         //タグ
    [SerializeField] private GameObject UI;　　　　　　//uiプレハブ
    private string methodName = "OnHit";　　　　　　　 //呼び出し関数名

    private void Start()
    {
        UI.SetActive(false);
    }
    void Update()
    {
        float Speed = walkSpeed;

        // Wキー（前方移動）
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Speed = runSpeed;
            }
            transform.position += Speed * transform.forward * Time.deltaTime;
        }

        // Sキー（後方移動）
        if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Speed = runSpeed;
            }
            transform.position -= Speed * transform.forward * Time.deltaTime;
        }

        // Dキー（右移動）
        if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Speed = runSpeed;
            }
            transform.position += Speed * transform.right * Time.deltaTime;
        }

        // Aキー（左移動）
        if (Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Speed = runSpeed;
            }
            transform.position -= Speed * transform.right * Time.deltaTime;
        }
    }

    //Ui呼び出し
    public void OnHit()
    {
        UI.SetActive(true);
    }

    //パーティクルの衝突判定
    private void OnParticleCollision(GameObject obj)
    {
        if (obj.gameObject.tag == "arrow")
        {
            SendMessage(methodName, SendMessageOptions.DontRequireReceiver);
        }
    }
}
