// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

System.Console.WriteLine("Ingrese el primer numero");
int numero1=int.Parse(Console.ReadLine());
System.Console.WriteLine("Ingrese el segundo numero");
int numero2=int.Parse(Console.ReadLine());

bool Amistosos(int n, int m)
{
    int sum1=1;
    int sum2=1;
  for(int i =2;i<=n/2;i++)
  {
        if(n%i==0)
        {
            sum1+=i;
        }
  }
   for(int j =2;j<=m/2;j++)
  {
        if(m%j==0)
        {
            sum2+=j;
        }
  }
  System.Console.WriteLine(sum1);
  System.Console.WriteLine(sum2);
  if(sum1==m && sum2==n)
  {
    return true;
  }
  else{
    return false;
  }
    
    
}

if(Amistosos(numero1,numero2))
{
    System.Console.WriteLine("Los numeros son amistosos");
}

else{
    System.Console.WriteLine("Los numeros no son amistosos");
}
//for(int i=1000; i<=1500)