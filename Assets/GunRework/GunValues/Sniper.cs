using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AWP : BaseGunClass, IGun
{
    
    public AWP() : base()
    {
        Timer = 2f;
        GunName = "Sniper";
        GunCurrentAmmo = 5;
        GunMagSize = 5;
        GunMaxAmmo = 100;
        GunReserveAmmo = 100;
        GunFireRate = 0.5f;
        GunDamage = 100f;
        FireRatePerSec = 1 / GunFireRate;
    }
    public override void GetGun()
    {
        GunObject = Resources.Load<GameObject>("sniper_rifle");
        PC = GunObject.GetComponent<ProjectileCreate>();
    }

    public override void Fire()
    {
        if (Timer > FireRatePerSec)
        {
            Debug.Log("Shoot");
            PC.FireGun(GunDamage);

            Timer = 0f;
        }
        else
        {
            Timer = Timer += Time.deltaTime;
        }
    }

}
