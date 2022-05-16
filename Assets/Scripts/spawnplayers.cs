using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class spawnplayers : MonoBehaviour
{
    public static spawnplayers instance;

    public GameObject player1;
    private GameObject cplayer;

 
  //  public GameObject point1spwan;
 //   public GameObject point2spawn;
  //  private GameObject points;
//
   // public GameObject point1;
   // public GameObject point2;


    public GameObject DeathEffect;

    //movement mo;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        if(PhotonNetwork.IsConnected)
        {
            SpawnPlayer();
        }
        
       
    }
    public void SpawnPlayer()
    {

        Transform spawnPoint = spawnManager.instance.GetSpawnPoint();

        cplayer = PhotonNetwork.Instantiate(player1.name, spawnPoint.position, spawnPoint.rotation);
       // points = PhotonNetwork.Instantiate(point1.name,point1spwan.transform.position,Quaternion.identity);
       // points = PhotonNetwork.Instantiate(point2.name,point2spawn.transform.position,Quaternion.identity);

    }


}

