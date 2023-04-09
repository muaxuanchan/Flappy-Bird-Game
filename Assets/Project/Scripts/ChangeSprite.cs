using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public Sprite[] pipeSprites;

    private void Awake()
    {
        int index = Random.Range(0, pipeSprites.Length);
        GetComponentsInChildren<SpriteRenderer>()[0].sprite = pipeSprites[index];
        GetComponentsInChildren<SpriteRenderer>()[1].sprite = pipeSprites[index];
    }
}
