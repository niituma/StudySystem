using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private int positionCount;
    private Camera mainCamera;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.useWorldSpace = false;
        positionCount = 0;
        mainCamera = Camera.main;
    }

    void Update()
    {
        // ���̃��C���I�u�W�F�N�g���A�ʒu�̓J�����O��10m�A��]�̓J�����Ɠ����ɂȂ�悤�L�[�v������
        transform.position = mainCamera.transform.position + mainCamera.transform.forward * 10;
        transform.rotation = mainCamera.transform.rotation;

        if (Input.GetMouseButton(0))
        {
            // ���W�w��̐ݒ�����[�J�����W�n�ɂ������߁A�^������W�ɂ����������
            Vector3 pos = Input.mousePosition;
            pos.z = 10.0f;

            // �}�E�X�X�N���[�����W�����[���h���W�ɒ���
            pos = mainCamera.ScreenToWorldPoint(pos);

            // ����ɂ�������[�J�����W�ɒ����B
            pos = transform.InverseTransformPoint(pos);

            // ����ꂽ���[�J�����W�����C�������_���[�ɒǉ�����
            positionCount++;
            lineRenderer.positionCount = positionCount;
            lineRenderer.SetPosition(positionCount - 1, pos);
        }
        //���Z�b�g����
        if (!(Input.GetMouseButton(0)))
        {
            positionCount = 0;
        }
    }

}