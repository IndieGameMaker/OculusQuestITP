using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabMgr : MonoBehaviour
{
    private Transform tr;
    private Transform grabObject;

    private bool isTouched = false;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isTouched && OVRInput.GetDown(OVRInput.Button.SecondaryHandTrigger))
        {
            grabObject.SetParent(this.transform); //컨트롤러 하위로 차일드화 시킴
            grabObject.GetComponent<Rigidbody>().isKinematic = true;
        }

        // if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        // {
        //     Debug.Log("왼손 트리거 버튼");
        // }
        // if (OVRInput.GetUp(OVRInput.Button.SecondaryHandTrigger))
        // {
        //     Debug.Log("오른손 그랩버튼");
        // }
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("BALL"))
        {
            grabObject = coll.transform;
            isTouched = true;
        }
    }
}
