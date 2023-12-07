using UnityEngine;

public class CoffeeMachine : Device
{
    [SerializeField] private Transform coffee;
    [SerializeField] private Transform player;

    public override void Interact()
    {
        base.Interact();

        MakeCoffee();
    }

    private void MakeCoffee()
    {
        Instantiate(coffee, transform.position + new Vector3(10, 0, 0), Quaternion.identity);
    }
}
