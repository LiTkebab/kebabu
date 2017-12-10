using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int speed = 10;
    Rigidbody2D rb2D;
    // Use this for initialization
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GoLeft()
    { //左にいく時の挙動
        Debug.Log("キャラクターが左に進んでいます");
        //GetComponent<Rigidbody2D> ().velocity = new Vector3 (1, 0, 0);
        transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        //rb2D.velocity = new Vector3(-100, 0, 0);
    }

    public void GoRight()
    { //右にいく時の挙動
        Debug.Log("キャラクターが右に進んでいます");
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }

    public void Jump()
    { //ジャンプの挙動
        Debug.Log("キャラクターがジャンプしています");

    }
}
