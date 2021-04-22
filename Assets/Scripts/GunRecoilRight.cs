using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRecoilRight : MonoBehaviour
{
    public Vector3 upRecoil;
    Vector3 originalRotation;

    // Start is called before the first frame update
    void Start()
    {
        originalRotation = transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            AddRecoil();
        }
        else if (Input.GetButtonUp("Fire2"))
        {
            StopRecoil();
        }
    }
    private void AddRecoil()
    {
        transform.localEulerAngles += upRecoil;
    }

    private void StopRecoil()
    {
        transform.localEulerAngles = originalRotation;
    }
}
