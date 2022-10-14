using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 20; //�v���C���[�̃X�s�[�h
    private Rigidbody rb;                      //Rigidbody

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();          //Rigidbody���擾
    }

    // Update is called once per frame
    void Update()
    {
        //�J�[�\���L�[���͂��擾
        var moveHorizotal = Input.GetAxis("Horizontal");
        var moveVertical   = Input.GetAxis("Vertical");

        //�J�[�\���L�[���͂ɍ��킹�Ĉړ�������ݒ�
        var movement = new Vector3(moveHorizotal, 0, moveVertical);

        //Ridigdbody�ɗ͂�^���ċʂ𓮂���
        rb.AddForce(movement * speed);
    }
}
