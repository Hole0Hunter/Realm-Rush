using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocator : MonoBehaviour
{
    Transform weapon;
    Transform target;
    Transform ballistaTop;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<EnemyMover>().transform;
        ballistaTop = this.transform.GetChild(1);
    }

    // Update is called once per frame
    void Update()
    {
        AimWeapon();
    }

    void AimWeapon()
    {
        ballistaTop.transform.LookAt(target);
    }
}
