using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PlayerControl : MonoBehaviourPunCallbacks
{
    public PhotonView PV;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PV.IsMine) transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime * 7, 0, 0));
    }
}
