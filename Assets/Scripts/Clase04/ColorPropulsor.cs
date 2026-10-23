using UnityEngine;

public class ColorPropulsor : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Color colorOriginal;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        colorOriginal = spriteRenderer.color;
    }

    public void CambiarColor(Color nuevoColor)
    {
        spriteRenderer.color = nuevoColor;
    }

    public void RestaurarColor()
    {
        spriteRenderer.color = colorOriginal;
    }
}
