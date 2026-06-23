using Andresom.DamageTypes;
using Andresom.Enemies;
using Andresom.Weapones;
using Andresom.Heroes;
using Andresom.Orcses;
using Andresom.Skeletones;
using Andresom.Knightes;
using Andresom.Wizzardes;
using Andresom.Archeres;

namespace Andresom.Entities;

abstract internal class Entity
{
    public string Model { get; private protected set; } = "Model not found";
    public Weapon Weapon { get; private protected set; }
    public byte Health { get; private protected set; } = 100;
    public byte Stamina { get; private protected set; } = 100;

    public Entity(Weapon weapon, string model, byte health, byte stamina)
    {
        this.Weapon = weapon;
        this.Model = model;
        this.Health = health;
        this.Stamina = stamina;
    }

    private protected virtual void Attacked_Enemy_Target(Entity target, Entity initiator)
    {
        if(target is Orc) target.Attacked_Enemy_Target(target, initiator);
        if(target is Skeleton) target.Attacked_Enemy_Target(target, initiator);
    }
    private protected virtual void Attacked_User_Target(Entity target, Entity initiator)
    {
        if (target is Knight) target.Attacked_User_Target(target, initiator);
        if (target is Wizzard) target.Attacked_User_Target(target, initiator);
        if (target is Archer) target.Attacked_User_Target(target, initiator);
    }

    private protected void StaminaSettings(Entity target)
    {
        if(target.Stamina + 10 >= 100) target.Stamina = 100;
        else target.Stamina += 10;
    }
}