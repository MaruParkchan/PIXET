using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Weapon : MonoBehaviour {

    static public float fireRate = 0.1f; // 처음 공격 속도
    public Animator weaponAni;
    public GameObject bullet;
    public GameObject fireEffect;
    public Transform firePoint;
    private float nextFire = 0;

    private float _HomingTime;
    Vector3 StartPos;
    Vector3 EndPos;

    private void Awake()
    {
      //  Cursor.visible = false;
    }

    private void Update()
    {
        if (DataController.instance.currentHp <= 0)
            SceneManager.LoadScene("GameOver");



        Look();
        if(Input.GetMouseButton(0))
        {
            if(Time.time > nextFire + fireRate)
            {
                weaponAni.Play("Weapon");
                nextFire = Time.time + fireRate;
                Fire();
            }
        }

        if (Input.GetMouseButtonUp(0))
            weaponAni.Play("None");
   
    }

   public void Look()
    {
        if (_HomingTime < 0)
        {
            _HomingTime = 1;
        }
        StartPos = transform.up;
        EndPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        EndPos.z = transform.position.z;
        EndPos.Normalize();
        //  180도 회전에 걸리는 시간을 기준으로 실제 이동 시간 조정 ( 내적을 활용함 )
        float Dot = Vector3.Dot(StartPos, EndPos);
        float Rate = 0;
        while (Rate < 1)
        {
            Rate += Time.deltaTime / _HomingTime;

            if (Rate > 1)
            {
                Rate = 1;
            }

            transform.up = Vector3.Slerp(StartPos, EndPos, Rate);


        }
    }


    public void Fire()
    {
        GameObject clone =  Instantiate(bullet);
        clone.transform.position = firePoint.position + new Vector3(0,0,5f);
        clone.transform.rotation = transform.rotation;

       // GameObject effect = Instantiate(fireEffect);
       // effect.transform.position = firePoint.position;
    }

    
}
