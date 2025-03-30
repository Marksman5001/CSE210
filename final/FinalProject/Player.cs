
class Player : Entity{

    private int _Money;

    public Player() :base(){
    }
    public Player(int health, int damage) : base(health, damage){
    }
    public Player(int health, int damage, int money) : base(health, damage){
        _Money=money;
    }
}