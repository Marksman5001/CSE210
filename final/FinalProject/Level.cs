
class Level{
    private List<Room> _Rooms;
    private int _Roomcount;
    public Level(){
        _Rooms=new List<Room>();
        _Roomcount=5;

    }
    public Level(int roomcount){
        _Rooms=new List<Room>();
        _Roomcount=roomcount;
        InitializeRooms();
    }

    private void InitializeRooms(){
        Random rand = new Random();
        for(int i=0; i<_Roomcount; i++){
            if(i==_Roomcount-1){
                Room room = new Room(true);
                _Rooms.Add(room);
            }
            else{
                Room room = new Room();
                _Rooms.Add(room);
            }
            
        }
    }
    public List<Room> GetRooms(){
        return _Rooms;
    }
    
}