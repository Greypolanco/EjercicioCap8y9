
public class Ejercicios{

    public static void Main(String[] args){
        dateTime();
    }

    public static void dateTime(){
        
        DateTime Date = DateTime.Now;

        Date.ToString(" HH:mm dddd, M, yyyy");
        System.Console.WriteLine(Date);
    }
}
