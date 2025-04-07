
class Player : Entity{

    private int _Money;
    private bool _MagicUnlock;
    private int _MaxHp;

    public Player() :base(){
        _MaxHp=20;
        _MaxHp=_Health;
        _MagicUnlock=false;
    }
    public Player(int health, int damage) : base(health, damage){
        _MaxHp=20;
        _MaxHp=_Health;
        _MagicUnlock=false;
    }
    public Player(int health, int damage, int money) : base(health, damage){
        _MaxHp=20;
        _Money=money;
        _MaxHp=_Health;
        _MagicUnlock=false;
    }
    public void Unlock(){
        _MagicUnlock=true;
    }
    public void LoseMoney(int money){
        _Money-=money;
    }
    public int Firebolt(){
        if(_MagicUnlock){
            return _Damage+10;
        }
        else{
            return 0;
        }
    }
    public int GetMoney(){
        return _Money;
    }
    public void AddMoney(int money){
        _Money+=money;
    }
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        System.Console.WriteLine($"-{damage} hp");
    }
    public bool GetUnlock(){
        return _MagicUnlock;
    }
    public void Heal(){
        _Health+=10+GetDamage();
        if(_Health>_MaxHp){
            _Health=_MaxHp;
        }
    }
    public int GetMaxHP(){
        return _MaxHp;
    }
    public void AddMaxHP(int maxhp){
        _MaxHp+=maxhp;
    }
}