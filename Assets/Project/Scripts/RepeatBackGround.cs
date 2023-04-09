using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackGround : MonoBehaviour
{

    public Sprite[] backgroundSprite;

    private float withBackGround;
    private Vector3 startPosition;

    private void Awake()
    {
        int index = Random.Range(0, backgroundSprite.Length);
        GetComponentsInChildren<SpriteRenderer>()[0].sprite = backgroundSprite[index];
        GetComponentsInChildren<SpriteRenderer>()[1].sprite = backgroundSprite[index];
    }

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        withBackGround = GetComponentInChildren<BoxCollider2D>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPosition.x - withBackGround)
        {
            transform.position = startPosition;
        }
    }
}
