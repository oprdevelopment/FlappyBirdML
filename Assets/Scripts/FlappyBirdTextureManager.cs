using UnityEngine;

public class FlappyBirdTextureManager : MonoBehaviour
{
    public Sprite[] sprites; 
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (sprites.Length > 0)
        {
            spriteRenderer.sprite = sprites[0];
        }
    }
    
    public void ChangeSprite(int index)
    {
        if (index >= 0 && index < sprites.Length)
        {
            spriteRenderer.sprite = sprites[index]; 
        }
    }
}

