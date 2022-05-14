using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 0;
    public Sprite[] bullet;
    private int index = 0;
    private SpriteRenderer sprite = null;
    AudioSource audio;
    private void Awake()
    {
        audio = GetComponent<AudioSource>();
        audio.PlayOneShot(audio.clip);
        sprite = GetComponent<SpriteRenderer>();
        Destroy(this.gameObject, 3.0f);
    }

    void Update()
    {
        ChangeImageBullet();
        Move();
    }

    public void Move()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.transform.tag == "Enemy")
        {
            col.transform.GetComponent<Enemy>().TakeDamage(DataController.instance.damage);
            Destroy(gameObject);
        }
    }

    public void ChangeImageBullet()
    {
        switch(StoreController.powerLevel)
        {
            case 1:
                sprite.sprite = bullet[0];
                break;
            case 2:
                sprite.sprite = bullet[1];
                break;
            case 3:
                sprite.sprite = bullet[2];
                break;
            case 4:
                sprite.sprite = bullet[3];
                break;
            case 5:
                sprite.sprite = bullet[4];
                break;

        }
    }

}
