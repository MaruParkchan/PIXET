using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    [Header("GroundMove")]
    public GameObject[] Genemy;

    [Header("FlyMove")]
    public GameObject[] Fenemy;

    public Transform[] wavePoint;
    public TimeAttack timeAttack;

    private int index;

    private void Start()
    {
        Invoke("cancelSpawn", 25f);
        EnemySpawns();
    }

    public void EnemySpawns()
    {
        if (DataController.instance.mapNum == 1)
        {
            InvokeRepeating("enemy01", 2.0f, 3.0f);
            InvokeRepeating("enemy02", 3.0f, 4.0f);
        }

        if (DataController.instance.mapNum == 2)
        {
            InvokeRepeating("enemy01", 5.0f, 8.0f);
            InvokeRepeating("enemy02", 4.0f, 4.0f);
            InvokeRepeating("enemy03", 4.0f, 4.0f);
            InvokeRepeating("enemy04", 4.0f, 4.0f);
        }

        if (DataController.instance.mapNum == 3)
        {
            InvokeRepeating("enemy01", 3.0f, 8.0f);
            InvokeRepeating("enemy02", 6.0f, 3.0f);
            InvokeRepeating("enemy03", 4.0f, 7.0f);
            InvokeRepeating("enemy04", 5.0f, 8.0f);
            InvokeRepeating("enemy05", 7.0f, 30.0f);
        }

        if (DataController.instance.mapNum == 4)
        {
            InvokeRepeating("enemy01", 2.0f, 5.0f);
            InvokeRepeating("enemy02", 3.0f, 3.0f);
            InvokeRepeating("enemy03", 4.0f, 7.0f);
            InvokeRepeating("enemy04", 5.0f, 8.0f);
            InvokeRepeating("enemy05", 4.0f, 5.0f);
        }

    }

    public void enemy01()
    {
        XEnemySpawn(0,-0.7f);
    }

    public void enemy02()
    {
        FlyEnemySpawn(0);
    }

    public void enemy03()
    {
        XEnemySpawn(1, -0.5f);
    }

    public void enemy04()
    {
        FlyEnemySpawn(1);
    }

    public void enemy05()
    {
        XEnemySpawn(2, -0.5f);
    }

    private void XEnemySpawn(int index , float yPos)
    {
        GameObject clone =  Instantiate(Genemy[index]);
        clone.transform.position = new Vector3(14.0f, yPos, 0);
    }

    private void FlyEnemySpawn(int Index)
    {
        index = Random.Range(0, wavePoint.Length);
        GameObject clone = Instantiate(Fenemy[Index]);
        clone.transform.position = wavePoint[index].position;
    }
    
    private void cancelSpawn()
    {
        CancelInvoke();
    }

}
