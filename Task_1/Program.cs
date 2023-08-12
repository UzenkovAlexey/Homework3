Console.WriteLine("Enter number A ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter numer B ");
int numB = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int numA, int numB)
{
  int result = 1;
  for(int i=1; i <= numB; i++)
  {
    result = result * numA;
  }
    return result;
}

  int exponentiation = Exponentiation(numA, numB);
  Console.WriteLine("" + exponentiation);
