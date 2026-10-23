using UnityEngine;

public class CambioColor : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            spriteRenderer.color = Color.red;
        }
    }

    public void CambiarColor(Color nuevoColor)
    {
        spriteRenderer.color = nuevoColor;
    }
}
