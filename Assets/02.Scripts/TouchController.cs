using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    private Camera arCamera;
    private RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        arCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        // 터치 좌표값
        Vector2 pos = Input.mousePosition;
        // 스크린 터치좌표값을 3차원 Ray 생성
        Ray ray = arCamera.ScreenPointToRay(pos);

        if (Input.GetMouseButtonDown(0)&&Physics.Raycast(ray,out hit ,10.0f,1<<8))
        {
            Destroy(hit.transform.gameObject);
            //Debug.Log($"Position x={pos.x}, y={pos.y}");
        }
    }
}
