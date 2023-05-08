namespace Enum_demo
{
    //enum Musicplayer { play,stop,repeat,volume,record=10}
    internal class Program
    {
        enum Musicplayer{ play=11, stop, repeat, volume, record = 10 }
        static void Main(string[] args)
        {
           
           // Console.WriteLine(Musicplayer.record);
            Console.WriteLine(Convert.ToInt32(Musicplayer.volume));
        }
    }
}