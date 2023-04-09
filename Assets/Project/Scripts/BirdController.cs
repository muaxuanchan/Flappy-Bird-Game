using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float flyPower;
    public GameObject scoreText;
    public AudioClip[] audioClips;

    private int randomNumber;
    private Rigidbody2D rb;
    private AudioSource audioSource;
    private Animator animator;
    private GameManager gameManager;


    private void Awake()
    {
         randomNumber = Random.Range(0, 2);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        animator.SetFloat("FlyPower", 0);
        animator.SetInteger("ChangeBird", randomNumber);
        gameManager = FindObjectOfType<GameManager>().GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            scoreText.SetActive(true);
            rb.AddForce(new Vector2(0, flyPower));
            animator.SetFloat("FlyPower", 1);
            PlayAudioClip(2);
        }

        if (Input.GetButtonUp("Fire1"))
        {
            animator.SetFloat("FlyPower", -1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.IncreaseScore();
        PlayAudioClip(1);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.EndGame();
        PlayAudioClip(0);
    }

    void PlayAudioClip(int index)
    {
        audioSource.clip = audioClips[index];
        audioSource.Play();
    }
}
