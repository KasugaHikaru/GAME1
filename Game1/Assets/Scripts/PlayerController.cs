using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 20; //プレイヤーのスピード
    private Rigidbody rb;                      //Rigidbody

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();          //Rigidbodyを取得
    }

    // Update is called once per frame
    void Update()
    {
        //カーソルキー入力を取得
        var moveHorizotal = Input.GetAxis("Horizontal");
        var moveVertical   = Input.GetAxis("Vertical");

        //カーソルキー入力に合わせて移動方向を設定
        var movement = new Vector3(moveHorizotal, 0, moveVertical);

        //Ridigdbodyに力を与えて玉を動かす
        rb.AddForce(movement * speed);
    }
}
