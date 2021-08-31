using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ChangeColor : MonoBehaviour
{
	SpriteRenderer _renderer;

	private void Start()
	{
		_renderer = GetComponent<SpriteRenderer>();
	}

	public int LerpVal
	{
		set => _renderer.material.SetFloat("_Lerp", Mathf.Clamp01(value));
	}
}
