/// <summary>
/// Parent class of enemies
/// </summary>
class Enemy : Entity{


    public Enemy() :base(){
    }
    public Enemy(int health, int damage): base(health, damage){
    }

    public bool Dead(){
        if(_Health<=0){
            return true;
        }
        else{
            return false;
        }
    }
}