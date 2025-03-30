class Player{
    private int _Health;
    private int _Damage;

    public Player(){
        _Health=0;
        _Damage=0;
    }
    public int GetHealth(){
        return _Health;
    }
    public int GetDamage(){
        return _Damage;
    }
    public void AddDamage(int damage){
        _Damage+=damage;
    }
    public void AddHealth(int health){
        _Health+=health;
    }
}