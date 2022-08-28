using UnityEngine;

public class PowerPellet : Pellet
{
    public float duration = 8f;

    private GameManager gameManager;

    public void Start()
    {
        gameManager = GetComponent<GameManager>();   
    }

    protected override void Eat()
    {
       gameManager.PowerPelletEaten(this);
    }

}
