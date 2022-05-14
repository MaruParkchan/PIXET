using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainImageChange : MonoBehaviour {

    public Sprite[] sprite;
    private SpriteRenderer render;

    private void Awake()
    {
        render = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (StoreController.shieldLevel == 1)
            render.sprite = sprite[0];

        if (StoreController.shieldLevel == 2)
            render.sprite = sprite[1];

        if (StoreController.shieldLevel == 3)
            render.sprite = sprite[2];

        if (StoreController.shieldLevel == 4)
            render.sprite = sprite[3];

        if (StoreController.shieldLevel == 5)
            render.sprite = sprite[4];
    }
}
