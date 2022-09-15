using System;

public class Axe
{
    private int durabilityPoints;
    public Axe(int attack, int durability)
    {
        AttackPoints = attack;
        this.durabilityPoints = durability;
    }

    public int AttackPoints { get; }

    public int DurabilityPoints { get => this.durabilityPoints; }

    public void Attack(Dummy target)
    {
        if (this.durabilityPoints <= 0)
        {
            throw new InvalidOperationException("Axe is broken.");
        }

        target.TakeAttack(AttackPoints);
        this.durabilityPoints -= 1;
    }
}
