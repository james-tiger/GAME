using UnityEngine;
using System.Collections.Generic;

[RequireComponent(typeof(Collider2D))]
public class Fruit : MonoBehaviour
{
    public int points = 10;

    protected virtual void Eat()
    {
        GameManager.Instance.FruitEaten(this); 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Pacman"))
        {
            Eat();
            gameObject.SetActive(false); 
        }
    }
}
