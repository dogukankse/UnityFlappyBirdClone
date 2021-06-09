using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
	[SerializeField] private float _moveSpeed;

	[SerializeField] private Vector2 _minMaxSize;
	[SerializeField] private BoxCollider2D _collider;
	[SerializeField] private Transform _top;
	[SerializeField] private Transform _bottom;

	void Update()
	{
		transform.position += Vector3.left * (_moveSpeed * Time.deltaTime);
	}

	public void Init()
	{
		float size = Random.Range(_minMaxSize.x, _minMaxSize.y);

		_collider.size = new Vector2(0.1f, size);

		float upperBound = _collider.bounds.max.y + 0.8f;
		float lowerBound = _collider.bounds.min.y - 0.8f;

		_top.position = new Vector3(_top.position.x, upperBound, 0);
		_bottom.position = new Vector3(_bottom.position.x, lowerBound, 0);
	}
}