using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    Collider2D coll;

    public float speed;
    Vector2 movement;
  
    //��������
    public GameObject Bag;
    bool isOpen;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();

    }


  
    void Update()
    {
        Movement();
        openBag();
    }


    void Movement()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
    }



    void openBag()
    {
        //����Bag��ʾ��������
        if (Input.GetKeyDown(KeyCode.O))
        {
            isOpen = !isOpen;
            Bag.SetActive(isOpen);
        }
    }
}
