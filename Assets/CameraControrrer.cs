using UnityEngine;

public class CameraController : MonoBehaviour
{
    float rotationSpeed = 2.0f;
    float mouse_X;
    float mouse_Y;
    public GameObject player;   // プレイヤーオブジェクトの変数

    void Update()
    {
        // マウスをクリックした場合
        if (Input.GetMouseButton(0))
        {
            mouse_X = Input.GetAxis("Mouse X") * rotationSpeed;
            mouse_Y = Input.GetAxis("Mouse Y") * rotationSpeed;
            transform.RotateAround(player.transform.position, Vector3.up, mouse_X); // Y軸に対して回転させる処理
            transform.RotateAround(player.transform.position, transform.right, mouse_Y); // X軸に対して回転させる処理
        }
    }
}
