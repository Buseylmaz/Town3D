using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuHareket : MonoBehaviour
{
    Camera cam;
    private Vector3 targetPos;

    private void Start()
    {
        cam = Camera.main;

    }
    private void Update()
    {
        int parmakSayisi = Input.touchCount;

        for (int i = 0; i < parmakSayisi; i++)
        {
            Touch parmak = Input.GetTouch(i);

            if (parmak.phase == TouchPhase.Began)
            {
                Ray ray = cam.ScreenPointToRay(parmak.position);
                RaycastHit raycastHit;
                if (Physics.Raycast(ray, out raycastHit, 100))
                {
                    transform.position = new Vector3(raycastHit.point.x, transform.position.y, raycastHit.point.z);
                }
            }
            else if (parmak.phase == TouchPhase.Moved)
            {

            }
        }
    }
}
