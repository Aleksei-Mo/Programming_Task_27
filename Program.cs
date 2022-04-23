// Задача 27. Напишите программу, которая принимает на вход число и выдает сумму цифр в данном числе.
Console.Clear();
Console.WriteLine("This programm gets the sum of all digit of your number.");
Console.Write("Enter your number: ");
string? userNumber = Console.ReadLine();
int sum=DigitSum(userNumber);
Console.WriteLine($"Sum of all digits in your number is equal to {sum}");

//*******************************************************//
int DigitSum(string? numberStr)
{char [] alphabet = {'1','2','3','4','5','6','7','8','9','0'};
 int [] digits = new int[numberStr.Length];
 int sum=0;
 
if(numberStr.Length<1)
  {
  Console.WriteLine("You entered the empty string. Try again!");
  }
  else
  {
   for (int index=0; index < numberStr.Length; index++)
     {
       for (int index2=0; index2 < alphabet.Length; index2++)// check current element: number or symbol
        { 
          if(numberStr[index] == alphabet[index2])
            {
             digits[index]=Convert.ToInt32(Convert.ToString(numberStr[index])); // if number then convert to integer and add to the array "digits". Before we convert char to string to correct converting from char to int.
             break;// don't lose time
            }
            else
            {
             digits[index]=0; // if symbol then add zero to the array "digits"
            }
           
        }
      
     }
   for (int index3=0; index3 < digits.Length; index3++)
    {
      sum=sum + digits[index3];
    } 
  }
   return sum;  
}
//******************************************************//