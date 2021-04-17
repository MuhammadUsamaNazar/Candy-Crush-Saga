﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScalar : MonoBehaviour
{
    private Board board;
    public float cameraOffset;
    // Start is called before the first frame update
    void Start()
    {
        board = FindObjectOfType<Board>();
        if (board != null)
        {
            RepositionCamera(board.width, board.height);
        }
    }

    void RepositionCamera(float x, float y)
    {
        Vector2 tempPosition = new Vector3(x / 2, y / 2, cameraOffset);
        transform.position = tempPosition;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
