using UnityEngine;

public class PowerPellet : Pellet
{
    public float duration = 8f;

    public void Start()
    {
        
    }

    protected override void Eat()
    {
        FindObjectOfType<GameManager>().PowerPelletEaten(this);
    }

}
