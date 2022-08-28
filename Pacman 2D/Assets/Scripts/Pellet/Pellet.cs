using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Pellet : MonoBehaviour
{
    public int points = 10;
    private GameManager gameManager;

    public void Start()
    {
        gameManager = GetComponent<GameManager>();
    }

    protected virtual void Eat()
    {
        gameManager.PelletEaten(this);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Pacman")) {
            Eat();
        }
    }

}
