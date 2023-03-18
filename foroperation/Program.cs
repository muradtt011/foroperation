// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/* TASK 1
int sum=0;
for (int i = 1; i <= 1000; i++)
{
    sum =sum+ i;
    Console.WriteLine(sum);
}

if (sum % 7 == 0)
{
    Console.WriteLine("BELI BOLUNUR");

}
else
{
    Console.WriteLine("XEYIR BOLUNMUR:");
}
*/

/*TASK 2
for (int i = 1; i <= 1000; i++)

    if (i % 7 == 0 && i % 8 == 0)
    {
        Console.WriteLine(i);
    }
}
*/

/* TASK 3
for (int i = 1; i <= 1000; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine(i);
    }
}
*/

/*TASK 4
for (int i = 1; i <= 1000; i++)
{
    int last = i % 10;
    if (i % 3 == 0 && last != 3)
    {
        Console.WriteLine(i);
    }
}
*/

/* TASK 5
for (int i = 5; i <= 1000; i += 5)
{
    int sum = 0;
    int number = i;
    while (number!=0)
    {
        sum+=number % 10;
        number /= 10;
    }
    if (sum % 5 == 0)
    {
        Console.WriteLine(i);
    }
}
*/

/*TASK 6
int temp1, temp2, qaliq,sum;
for (int i = 1; i <= 1000; i++)
{
    sum = 0;
    temp1 = i;
    temp2 = i * 10;
    while (temp1 > 0)
    {
        qaliq = temp1 % 10;
        temp1 /= 10;
        sum += qaliq;
        temp2 /= 10;
    }
    if (sum % 2 == 1 && i % 2 == 0 && temp2 % 2 == 1)
    {
      Console.WriteLine(i);
    }
  
}
*/

/*TASK 7
for (int i = 1; i <= 1000; i++)
{
    int temp1 = i / 10;
    int temp2 = i / 100;
    if (i % 10 != 3 && temp1 % 10 != 3 && temp2 % 10 != 3)
    {
        Console.WriteLine(i);
    }
}
*/
/*TASK 8
int a, b, c;
for(int i=0;i<1000;i++)
{
    a = i / 100;
    b= i / 10 % 10;
    c = i % 10;
    if(a!=3 && b!=3 && c!=3 && a+b+c==3)
    {
        Console.WriteLine(i);
       
    }

}
*/




/*TASK 9
int b = 1;
for(int i = 11; i < 1000; i+=11)
{
    int sum = 0;
    int number = i;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    if (sum > 11)
    {
        if (b == 12)
        {
            break;
        }
        Console.WriteLine($"{b} {i} {sum}");
        b++;
    }

    }
*/

/*TASK 10
for (int i = 0; i < 1000; i += 2)
{
    int sum = 0;
    int number = i;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    if (sum > 5 && sum < 7)
    {
        Console.WriteLine($"{i} {sum}");
    }
}
*/


/*TASK 11
for (int i = 1; i < 1000; i++)
{
    int number = i;
    int sum = 0;
    int qaliq;
    while (number > 0)
    {
        qaliq = number % 10;
        if (qaliq != 3)
        {
            sum = (sum * 10) + qaliq;
        }
        number /= 10;
    }
    if (sum == i)
    {
        int sum2 = sum;
        int sum3 = 0;
        while (sum2 > 0)
        {
            sum3 += sum2 % 10;
            sum2 /= 10;
}
            if (sum3 > 10)
            {
                Console.WriteLine($"{sum} cemi:{sum3}");
            }
        }
    }
*/


/*TASK 12
for (int i = 11; i <= 100000; i++)
{
    int number = i;
    int qaliq = number % 10;
    int number1 = number / 10;
    while (number1 > 0 && number1 % 10 == qaliq)
    {
        number1 /= 10;
    }
    if (number1 == 0)
    {
        int number2 = i;
        if (number2 % 10 == 5)
        {
            continue;
        }
        int sum = 0;
        while (number2 > 0)
        {
            sum += number2 % 10;
            number2 /= 10;
        }
        if (sum > 5)
        {
            Console.WriteLine(i);
        }
    }
}
*/


/*TASK 13
int temp, newnumber;
int number1, qaliq, qaliq2, count;
for (int i = 100; i < 100001; i++)
{
    count = 0;
    qaliq = i % 10;
    number1 = i / 10;
    if (qaliq % 2 == 1)
    {
        while (number1 > 0 && number1 % 2 == 1)
        {
            if (number1 % 10 == 5)
            {
                count = 1;
            }
            number1 /= 10;
        }
    }
    if (number1 == 0 && count == 1)
    {
        newnumber = 0;
        temp = i;
        while (temp > 0)
        {
            qaliq2 = temp % 10;
            newnumber = newnumber * 10 + qaliq2;
            temp /= 10;
        }
        if (newnumber == i)
        {
            Console.WriteLine(i);
        }
    }
}
*/



/*TASK 14
int number1, qaliq, count1, count2, sum, number2;
for (int i = 100; i <= 100001; i++)
{
    count1 = 0;
    count2 = 0;
    qaliq = i % 10;
    number1 = i;
    while (number1 > 0)
    {
        if (number1 % 10 == 6)
        {
            break;
        }
        if (number1 % 100 == 11)
        {
            count2 = 2;
        }
        if (number1 % 10 == 5)
        {
            count1++;
        }
        number1 /= 10;
    }

    if (count2 == 2 && count1 == 2)
    {
        number2 = i;
        sum = 0;
        while (number2 > 0)
        {
            sum += number2 % 10;
            number2 /= 10;
        }
        if (sum > 7 && sum < 15)
        {
            Console.WriteLine(i);
        }
    }
}
*/


//TASK 15
int temp, digit, sum;
int[] exclude = { 0, 1, 5, 7, 9 };
for (int i = 1; i <= 10000; i++)
{
l1:
    sum = 0;
    if (i % 2 == 0 || (i % 3 == 0 && i != 3) || i % 5 == 0 || i % 7 == 0)
    {
        continue;
    }
    temp = i;
    while (temp > 0)
    {
        digit = temp % 10;
        if (Array.IndexOf(exclude, digit) != -1)
        {
            i++;
            goto l1;
        }
        sum += digit;
        temp /= 10;
    }
    while (sum > 0)
    {
        digit = sum % 10;
        if (digit == 2)
        {
            i++;
            goto l1;
        }
        sum /= 10;
    }
    Console.WriteLine(i);
}























