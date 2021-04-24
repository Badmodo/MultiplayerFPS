using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;

public class PlayerManager : MonoBehaviour
{
    PhotonView PV;

    void Awake()
    {
        PV = GetComponent<PhotonView>();
    }

    void Start()
    {
        //Debug.Log("Testing player controller");
        if(PV.IsMine)
        {
            CreateController();
        }
    }

    void Update()
    {
        
    }

    void CreateController()
    {
        PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "Player"), Vector3.zero, Quaternion.identity);
    }
}
