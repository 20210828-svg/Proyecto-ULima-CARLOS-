using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Vamos a crear la referencia a la física del personaje
    // La referencia se usa colocando
    // Componente alias
    Rigidbody2D body;

    // Acá se crean dos atributos que van a poder ser modicados en el editor
    // y serán usados para modificar la velocidad del personaje
    [SerializeField] float speedX;
    [SerializeField] float speedY;

    // Awake es un método que se activa al "despertarse" el gameObject, se suele usar para cargar
    // información o alguna acción del propio objeto
    void Awake()
    {
        // Cuando se despierta el personaje, detecta su cuerpo
        body = GetComponent<Rigidbody2D>();
    }

    // Start es un método que se activa después del Awake, se suele usar este método para colocar
    // información de la escena, ejemplo si es un personaje detectas acá cuántos enemigos hay cerca
    void Start()
    {
        
    }

    // Update es un método que se llama muchas veces por segundo, por ejemplo si su juego corre
    // a 60 FPS, significa que entre cada imagen (frame) solo tienen 0.016 segundos o 16 milisegundos
    void Update()
    {
        // El personaje se moverá a 3 unidades de Unity por segundo (3 cuadrados/segundo)
        // Usamos los atributos creados speedX y speedY
        body.linearVelocityX = speedX;
        body.linearVelocityY = speedY;
    }
}
