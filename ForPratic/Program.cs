
// Soru1:
Console.WriteLine("*****Soru1*****");

string motivation = "Kendime inanıyorum, ben bu yazılım işini hallederim.";

for (int i =1; i<=10; i++)
{
    Console.WriteLine(i+")"+motivation);
}

//Soru2:
Console.WriteLine("*****Soru2*****");

for (int i=1; i<=20; i++)
{
    Console.WriteLine(i);
}

//Soru3:
Console.WriteLine("*****Soru3*****");

for (int i=2;i <=20; i += 2)
{
    Console.WriteLine(i);
}

//Soru4:
Console.WriteLine("*****Soru4*****");
int j;
int sum = 0;
for ( j=50; j<=150; j++)
{
    sum += j;
  
}

Console.WriteLine("toplam: "+sum);

//Soru5:
Console.WriteLine("*****Soru5*****:");

int sum2 = 0;
int sum3 = 0;

for(int i=1; i<=120; i += 2)
{
    sum3 += i; 
    sum2 +=(i + 1); // Bir sonraki çift sayıyı topluyoruz
}
Console.WriteLine("1-120 ARASINDAKİ TEK SAYILARIN TOPLAMI: " +sum3);

Console.WriteLine("1-120 ARASINDAKİ ÇİFT SAYILARIN TOPLAMI: "+sum2);