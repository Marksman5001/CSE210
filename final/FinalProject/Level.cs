
class Level{
    private List<Room> _Rooms;
    private int _Roomcount;
    public Level(){
        _Rooms=new List<Room>();
        _Roomcount=5;

    }
    public Level(int roomcount){
        _Roomcount=roomcount;
        InitializeRooms();
    }

    private void InitializeRooms(){
        Random rand = new Random();
        for(int i=0; i<_Roomcount; i++){

            Room room = new Room();
            _Rooms.Add(room);
        }
    }
    
}