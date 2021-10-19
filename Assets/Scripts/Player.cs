using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rigid;
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;
    private float _velocidad = 3;
    [SerializeField] private float _saltar = 10;
    [SerializeField] private LayerMask _layer;

    // Start is called before the first frame update
    void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }

    private void Movimiento()
	{
        float mover = Input.GetAxisRaw("Horizontal");
        if (mover != 0)
		{
            _animator.SetInteger("Run", 1);
		} else
		{
            _animator.SetInteger("Run", 0);
        }
        if (mover > 0)
		{
            _spriteRenderer.flipX = false;
        } else if (mover < 0)
		{
            _spriteRenderer.flipX = true;
        }
        _rigid.velocity = new Vector2(mover * _velocidad, _rigid.velocity.y);

        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.down, 0.6f, _layer);
        Debug.DrawRay(transform.position, Vector2.down * 0.6f, Color.cyan);
        if (hitInfo.collider != null)
		{
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _rigid.velocity = new Vector2(_rigid.velocity.x, _saltar);
            }
        }
    }
}
