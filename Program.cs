River Riv = new River("IRiver", 43, 123, 5, 1234);
Riv.ShowInfo();
Console.WriteLine("Interface");
Mountain Mou = new Mountain("IMountain", 122, 33, 4123);
Mou.ShowInfo();
interface IGeoObject
{
    abstract void ShowInfo();
}
class River : IGeoObject
{
    private int x;
    private int y;
    private string Name;
    private int speed;
    private int lengh;
    public River(string Name, int x, int y, int _speed, int _lengh)
    {
        this.Name = Name;
        this.x = x;
        this.y = y; 
        this.speed = _speed;
        this.lengh = _lengh;
    }
    public void ShowInfo()
    {
        Console.WriteLine("X: " + x);
        Console.WriteLine("Y: " + y);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine($"Speed : {this.speed} km/h");
        Console.WriteLine($"Lengh : {this.lengh} km");
    }
}
class Mountain : IGeoObject
{
    private int x;
    private int y;
    private string Name;
    private int highPoint;
    public Mountain(string Name, int x, int y, int _highPoint)
    {
        this.Name = Name;
        this.x = x;
        this.y = y;
        this.highPoint = _highPoint;
    }
    public void ShowInfo()
    {
        Console.WriteLine("X: " + x);
        Console.WriteLine("Y: " + y);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine($"High point : {this.highPoint} m");
    }
}