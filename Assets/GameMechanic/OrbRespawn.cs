﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbRespawn : MonoBehaviour {


    private void Update()
    {
      
    }

    private void OnCollisionEnter(Collision collision)
    {
		Destroy(this);
    }


}
