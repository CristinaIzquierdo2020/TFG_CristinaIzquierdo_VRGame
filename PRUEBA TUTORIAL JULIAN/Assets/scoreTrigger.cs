﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision collision)
    {
      if(collision.transform.name == "PalitoBaloncestoScore")
      {
          scoreBaloncesto.Score += 2;
      }
    }
}
