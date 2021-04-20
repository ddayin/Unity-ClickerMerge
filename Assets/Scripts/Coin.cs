using System;
using DG.Tweening;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public float effectDuration = 0.5f;

    private void Awake()
    {
        spriteRenderer = transform.GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        PlayEffect();
    }

    public void PlayEffect()
    {
        transform.DOLocalMoveY(2f, effectDuration);
        spriteRenderer.DOFade(0f, effectDuration);
        
        Invoke("Destroy", effectDuration);
    }

    private void Destroy()
    {
        Destroy(this.gameObject);
    }
}
