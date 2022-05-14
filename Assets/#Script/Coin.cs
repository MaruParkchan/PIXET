using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    [Header("돈")]
    public int num; // 돈
    private Transform target = null;
    public float speed = 0;

    private Rigidbody2D rigid = null;
    private bool isTrace = false;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        target = GameObject.FindWithTag("Player").transform;
        RandomCoin();
        StartCoroutine(TarcePlayer());
    }

    private void Update()
    {
        if (isTrace != false)
            TargetTrace();
    }

    IEnumerator TarcePlayer()
    {
        yield return new WaitForSeconds(1.0f);
        isTrace = true;
    }

    public void TargetTrace()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        Vector3 dir = (target.position - transform.position).normalized;
        transform.position += dir * Time.smoothDeltaTime * speed;
    }

    public void RandomCoin()
    {
        rigid.AddForce(new Vector2(Random.Range(-2, 2f), Random.Range(-2, 2f)), ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.transform.tag == "Player")
        {
            DataController.instance.money += num;
            Destroy(this.gameObject);
        }
    }
}
