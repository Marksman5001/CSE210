
class Entity{
    protected int _Health;
    protected int _Damage;

    public Entity(){
        _Health=0;
        _Damage=0;
    }

    public Entity(int health, int damage){
        _Health=health;
        _Damage=damage;
    }

    public void TakeDamage(int damage){
        _Health-=damage;
    }
    public int GetDamage(){
        return _Damage;
    }
    public void SetDamage(int damage){
        _Damage=damage;
    }
    public int GetHealth(){
        return _Health;
    }
    public void SetHealth(int health){
        _Health=health;
    }   

}