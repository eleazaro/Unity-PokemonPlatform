using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private CircleCollider2D cricle;
    public GameObject collected;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        cricle = GetComponent<CircleCollider2D>();
    }

    void OnTriggerEnter2D(Collider2D collider){
    if (collider.gameObject.tag == "Player")
    {
        spriteRenderer.enabled = false;
        cricle.enabled = false;
        collected.SetActive(true);

        GameController.instance.totalScore += score;
        GameController.instance.UpdateScore();
        
        Destroy(gameObject, 0.30f);
    }
    }
}
