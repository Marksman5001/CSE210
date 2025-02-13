using System;
using System.Security.Principal;
using System.Windows;

public class Tile{
    private List<int> color = new List<int>();
    private string type;
    private List<int> coords =new List<int>();
    
    public Tile(List<int> rgb, string tiletype, List<int> coordinates){
        this.type=tiletype;
        this.color=rgb;
        this.coords=coordinates;
}

}