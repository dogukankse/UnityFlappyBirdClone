using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[SerializeField] private float _moveSpeed;

	[SerializeField] private UIController _ui;
	
	private Rigidbody2D _rb;
	private int _score;

	private void Awake()
	{
		_rb = GetComponent<Rigidbody2D>();
	}

	private void Start()
	{
		Time.timeScale = 0;
	}

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			_rb.velocity = Vector2.up*_moveSpeed;
			if (Time.timeScale == 0)
				Time.timeScale = 1;
		}
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		print("Dead");
		_ui.PlayerDead();
		Time.timeScale = 0;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		_score++;
		_ui.UpdateScore(_score);
		print(_score);
	}
}
