using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoveTopDown : MonoBehaviour
{
    // float es número decimal
    [SerializeField] float speed;

    Rigidbody2D body;

    // Vamos a referenciar el input para el movimiento
    InputAction moveAction;

    void Awake()
    {
        // Cargarmos los componentes del objeto (Player)}
        body = GetComponent<Rigidbody2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Al momento de iniciar el player, cargamos del archivo Inputs y guardamos en nuestro inputAction
        // Como se carga de un archivo externo, entonces por preceptos usamos el Start
        moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        // Acá vamos a detectar en todo momento qué tecla hemos presionado, de eso se encarga moveAction
        Vector2 direction = moveAction.ReadValue<Vector2>();
        // El personaje se mueve en dirección de las teclas que se han presionado.
        body.linearVelocityX = direction.x * speed;
        body.linearVelocityY = direction.y * speed;
    } 
}
