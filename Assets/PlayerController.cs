using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour

{
    [SerializeField]
    private float speed;

    private PlayerMotor motor;

    private void Start() // Permet d'avoir accès aux objets dans PlayerMotor depuis PlayerController
    {
        motor = GetComponent<PlayerMotor>();
    }

    private void Update()
    {
        // Calculer la vitesste du mouvement de notre joueur
        float xMov = Input.GetAxisRaw("Horizontal");
        float zMov = Input.GetAxisRaw("Vertical");

        Vector3 moveHorizontal = transform.right * xMov;
        Vector3 moveVertical = transform.forward * xMov;

        Vector3 velocity = (moveHorizontal + moveVertical).normalized * speed;

        motor.Move(velocity);
    }
}
