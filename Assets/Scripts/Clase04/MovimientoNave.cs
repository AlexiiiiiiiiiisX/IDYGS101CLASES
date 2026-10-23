using UnityEngine;

public class MovimientoNave : MonoBehaviour
{
    public float velocidad = 5f;

    // Qué tan rápido la nave alcanza su velocidad.
    // Si es muy alta, la luna resbala y puede caerse.
    public float aceleracion = 8f;

    public ColorPropulsor propulsor;

    private Rigidbody2D rb;
    private Vector2 direccion;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        direccion = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            direccion.y += 1;
        }

        if (Input.GetKey(KeyCode.S))
        {
            direccion.y -= 1;
        }

        if (Input.GetKey(KeyCode.A))
        {
            direccion.x -= 1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            direccion.x += 1;
        }

        if (direccion.y > 0)
        {
            propulsor.CambiarColor(Color.red);
        }
        else if (direccion.y < 0)
        {
            propulsor.CambiarColor(Color.green);
        }
        else if (direccion.x != 0)
        {
            propulsor.CambiarColor(Color.yellow);
        }
        else
        {
            propulsor.RestaurarColor();
        }
    }

    void FixedUpdate()
    {
        Vector2 velocidadDeseada = direccion.normalized * velocidad;

        // La velocidad cambia poco a poco para que la fricción
        // pueda arrastrar a la luna junto con la nave.
        rb.linearVelocity = Vector2.MoveTowards(
            rb.linearVelocity,
            velocidadDeseada,
            aceleracion * Time.fixedDeltaTime
        );
    }
}
