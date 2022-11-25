﻿using System;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    [SerializeField] private float zOffset;
    private Camera _camera;

    private void Awake() => _camera = Camera.main;

    private void Update()
    {
        transform.position =
            _camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, zOffset));
    }
}