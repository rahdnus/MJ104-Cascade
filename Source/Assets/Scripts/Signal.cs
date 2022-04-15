using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signal : MonoBehaviour
{
    public SignalColor Type;

    Rigidbody2D rb;
    Vector2 moveDirection;
    [SerializeField] float moveSpeed=1;
    void Awake()
    {
        rb=GetComponent<Rigidbody2D>();
    }
    public void Init(SignalColor newType,Vector3 direction)
    {
        Type=newType;
        GetComponent<SpriteRenderer>().color=GameManager.Instance.SignalColorGenerator(Type);

        moveDirection=direction;
    }
    void FixedUpdate()
    {        
        rb.velocity=moveDirection*moveSpeed;
        // rb.MovePosition((transform.position+new Vector3(moveDirection.x,moveDirection.y,0))*moveSpeed);
    }
    public void ChangeSignal(SignalColor signaltype)
    {
        Type=signaltype;
        ChangeColor(GameManager.Instance.SignalColorGenerator(Type));
    }
    void ChangeColor(Color color)
    {
        GetComponent<SpriteRenderer>().color=color;
    }
}
    public enum SignalColor
    {
        Undefined,Red,Lime,Cyan,Purple,Yellow
    }