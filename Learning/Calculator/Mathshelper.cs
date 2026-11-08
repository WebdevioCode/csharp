namespace Mathshelper;

class Calc
{
    public static int add(string a,string b)
    {
     int newFirstNumber = Convert.ToInt32(a);
     int newSecondNumber = Convert.ToInt32(b);

     return newFirstNumber + newSecondNumber;   
    }

    public static int sub(string a,string b)
    {
     int newFirstNumber = Convert.ToInt32(a);
     int newSecondNumber = Convert.ToInt32(b);

     return newFirstNumber - newSecondNumber;   
    }

    public static int multi(string a,string b)
    {
     int newFirstNumber = Convert.ToInt32(a);
     int newSecondNumber = Convert.ToInt32(b);

     return newFirstNumber * newSecondNumber;   
    }

    public static int div(string a,string b)
    {
     int newFirstNumber = Convert.ToInt32(a);
     int newSecondNumber = Convert.ToInt32(b);

     return newFirstNumber / newSecondNumber;   
    }
}
