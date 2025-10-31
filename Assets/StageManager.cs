using UnityEngine;

/// <summary>
/// �V���v���ȃX�e�[�W�����X�N���v�g
/// �Q�[���J�n���Ɏw�肵���v���n�u�𐶐����邾��
/// </summary>
public class StageManager : MonoBehaviour
{
    [Header("�X�e�[�W����")]
    [Tooltip("�X�e�[�W�v���n�u�i�K�{�j")]
    [SerializeField] private GameObject stagePrefab;

    [Tooltip("�ʒu�i���ݒ�Ȃ炱�̃I�u�W�F�N�g�ʒu�ɐ����j")]
    [SerializeField] private Transform spawnPoint;

    private void Start()
    {
        SpawnStage();
    }

    /// <summary>
    /// �X�e�[�W�𐶐�
    /// </summary>
    private void SpawnStage()
    {
        if (stagePrefab == null)
        {
            return;
        }

        // �����ʒu�Ɖ�]������
        Vector3 spawnPos = (spawnPoint != null) ? spawnPoint.position : transform.position;
        Quaternion spawnRot = (spawnPoint != null) ? spawnPoint.rotation : Quaternion.identity;

        // �X�e�[�W�𐶐�
        Instantiate(stagePrefab, spawnPos, spawnRot);
    }
}
