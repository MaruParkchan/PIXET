using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum EnemyType
{
    None = -1,
    GroundMove = 1,
    FlyMove,
}

public class Enemy : MonoBehaviour {

    private Transform target = null;
    private Slider hpbar = null;
    public GameObject clone = null;
    public GameObject moneyClone = null;
    public EnemyType enemyType = EnemyType.None;

    public int hp = 0;
    private int maxHP = 0;
    public float speed = 0;
    public int enemyScore;
    public int coinCount = 0;
    public int damage = 0;

    private void Awake()
    {
        maxHP = hp;
        hpbar = GetComponentInChildren<Slider>();
        hpbar.maxValue = maxHP;
        target = GameObject.FindWithTag("Player").transform;
    }

    private void Update()
    {
        HpView(); // hpbar 상태

        if (enemyType == EnemyType.FlyMove)
            TargetTrace(); // Player 추적

        else if (enemyType == EnemyType.GroundMove)
            transform.position += Vector3.left * Time.deltaTime * speed;

        enemyDie();
    }

    public void TargetTrace()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance < 1.0f)
            return;

        Vector3 dir = (target.position - transform.position).normalized;

        transform.position += dir * Time.smoothDeltaTime * speed;

    }

    public void enemyDie()
    {
        if(hp <= 0)
        {
            Instantiate(clone, transform.position,clone.transform.rotation);

            for (int i = 0; i <= coinCount; i++)
                Instantiate(moneyClone, transform.position, clone.transform.rotation);

            DataController.instance.score += enemyScore;
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        hp  -= damage;
    }

    public void HpView()
    {
        hpbar.value = hp;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.transform.tag == "Player")
        {
            Debug.Log("타격");
            Instantiate(clone, transform.position, clone.transform.rotation);
            DataController.instance.currentHp -= damage;
            Destroy(gameObject);
        }
    }

}
