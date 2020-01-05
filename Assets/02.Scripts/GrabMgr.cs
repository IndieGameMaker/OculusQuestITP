using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabMgr : MonoBehaviour
{
    private Transform tr;
    private Transform grabObject;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            Debug.Log("왼손 트리거 버튼");
        }
        if (OVRInput.GetUp(OVRInput.Button.SecondaryHandTrigger))
        {
            Debug.Log("오른손 그랩버튼");
        }
    }
}
