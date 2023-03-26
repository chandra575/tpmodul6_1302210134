using tpmodul6_1302210134;
public class Program
{
    public static void Main(string[] args)
    {
    

        string videoTitle = "Tutorial Design By Contract - Chandra Bayu Samudra";
        SayaTubeVideo myVideo = new SayaTubeVideo(videoTitle);
        myVideo.IncreasePlayCount(1000);
        for (int i = 0; i < 20000000; i += 10000000)
        {
            try
            {
                myVideo.IncreasePlayCount(10000000);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                break;
            }
        }
        myVideo.PrintVideoDetails();

        Console.ReadLine(); 
    }
}