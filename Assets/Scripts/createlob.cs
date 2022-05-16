using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
public class createlob : MonoBehaviourPunCallbacks
{
    public InputField create;
    public InputField join;
    // Start is called before the first frame update

    public void Createroom()
    {
        PhotonNetwork.CreateRoom(create.text);
    }

    public void Joinroom()
    {
        PhotonNetwork.JoinRoom(join.text);

    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Map1");
        Debug.Log("joined");

    }




}
