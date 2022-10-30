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
        // このラインオブジェクトを、位置はカメラ前方10m、回転はカメラと同じになるようキープさせる
        transform.position = mainCamera.transform.position + mainCamera.transform.forward * 10;
        transform.rotation = mainCamera.transform.rotation;

        if (Input.GetMouseButton(0))
        {
            // 座標指定の設定をローカル座標系にしたため、与える座標にも手を加える
            Vector3 pos = Input.mousePosition;
            pos.z = 10.0f;

            // マウススクリーン座標をワールド座標に直す
            pos = mainCamera.ScreenToWorldPoint(pos);

            // さらにそれをローカル座標に直す。
            pos = transform.InverseTransformPoint(pos);

            // 得られたローカル座標をラインレンダラーに追加する
            positionCount++;
            lineRenderer.positionCount = positionCount;
            lineRenderer.SetPosition(positionCount - 1, pos);
        }
        //リセットする
        if (!(Input.GetMouseButton(0)))
        {
            positionCount = 0;
        }
    }

}