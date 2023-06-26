using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class LlaveController : MonoBehaviour
{
    public AudioSource clip;

    // Start is called before the first frame update
    public GameManager gameManager;
    private bool llaveRecogida = false;
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !llaveRecogida)
        {
            clip.Play();
            gameManager.llaves();
            Destroy(gameObject);
            llaveRecogida = true;
        }
    }
}
