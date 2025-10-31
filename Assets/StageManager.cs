using UnityEngine;

/// <summary>
/// シンプルなステージ生成スクリプト
/// ゲーム開始時に指定したプレハブを生成するだけ
/// </summary>
public class StageManager : MonoBehaviour
{
    [Header("ステージ生成")]
    [Tooltip("ステージプレハブ（必須）")]
    [SerializeField] private GameObject stagePrefab;

    [Tooltip("位置（未設定ならこのオブジェクト位置に生成）")]
    [SerializeField] private Transform spawnPoint;

    private void Start()
    {
        SpawnStage();
    }

    /// <summary>
    /// ステージを生成
    /// </summary>
    private void SpawnStage()
    {
        if (stagePrefab == null)
        {
            return;
        }

        // 生成位置と回転を決定
        Vector3 spawnPos = (spawnPoint != null) ? spawnPoint.position : transform.position;
        Quaternion spawnRot = (spawnPoint != null) ? spawnPoint.rotation : Quaternion.identity;

        // ステージを生成
        Instantiate(stagePrefab, spawnPos, spawnRot);
    }
}
