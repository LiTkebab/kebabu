using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    Player player;

    // Use this for initialization
    void Start()
    {
        player = GetComponent<Player>();

    }

    // Update is called once per frame
    void Update()
    {

        //プレイヤーの操作
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            //Aと←でプレイヤーを左に移動させる
            player.GoLeft();

        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            //Dと→でプレイヤーを左に移動させる
            player.GoRight();
        }
        if (Input.GetKey(KeyCode.Space))
        {
            //スペースバーでプレイヤーを左に移動させる
            player.Jump();


        }


        //温度変化
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            //Wと↑で温度を上昇させる




        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            //Sと↓で温度を降下させる


        }

    }

}