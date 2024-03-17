//---------------------------------------------------------------------------------
//task1

//int tempuratur = Convert.ToInt32(Console.ReadLine());
//if (tempuratur >15)
//{
//    Console.WriteLine("hava isdidir");
//}
//else
//{
//    Console.WriteLine("hava soyuqdur");
//}


//---------------------------------------------------------------------------------
//task2


//Console.WriteLine("Ay daxil edin:");
//string mounth =Convert.ToString(Console.ReadLine());
//switch (mounth)

//{
//	case "yanvar":
//	case "mart":
//	case "may":
//	case "iyul":
//	case "avqust":
//	case "octyabr":
//	case "dekabr":
//		Console.WriteLine("31 gun");
//		break;
//	case "aprel":
//	case "iyin":
//	case "sentyabr":
//	case "noyabr":
//		Console.WriteLine("30 gundur");
//		break;
//	case "fevral":
//		Console.WriteLine("28 ve ya 29 gundur");
//		break;

//}

//---------------------------------------------------------------------------------
//task3


//Console.WriteLine("eded daxil edin:");
//int num = Convert.ToInt32(Console.ReadLine());
//int faktorial = 1;

//for (int i = 2; i <=num; i++)
//{
//    faktorial *=i;

//}
//Console.WriteLine(faktorial);


//---------------------------------------------------------------------------------
//task4



//int num = Convert.ToInt32(Console.ReadLine()); 

//if (num  >2) 
//{
//    for (int i = 2; i < num; i++)
//    {
//        if (num % i == 0)
//        {
//            Console.WriteLine("murekeb ededdir");
//            break;
//        }
//        else {
//            Console.WriteLine("sade ededdir");
//            break;

//        }
//    }
//}
//else
//{
//    Console.WriteLine("ne sade ne murekeb ededdir");
//}



//---------------------------------------------------------------------------------
//task5

//int[] arr = { 12, 13, 15, 17, 32, 17 };
//int sum = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0) {
//        sum += arr[i];
//    }   
//}
//Console.WriteLine(sum);

//---------------------------------------------------------------------------------
//task6

//int[] arr = { -13, 15, 17, 19, 20, 2, 15};
//int max = arr[0];
//for (int i = 0; i < arr.Length; i++)
//{
//	if (arr[i]>max)
//	{
//      max = arr[i];
//	}
//}
//Console.WriteLine("arraydaki en boyuy eded:"+max);


//---------------------------------------------------------------------------------
//task7



//int num = Convert.ToInt32(Console.ReadLine());
//int first = num;
//bool result = false;    
//while (first != 0)
//{
//    int temp = first % 10;
//    int second=first / 10;
//    while (second != 0)
//    {
//        if (temp ==second%10)
//        {
//            result = true;  
//            break;

//        }
//        second /= 10;
//    }

//    first /= 10;

//}
//if (result)
//{
//    Console.WriteLine("tekrarlanan eded var ");
//}
//else
//{
//    Console.WriteLine("takrarlanan eded yoxdur");
//}

//---------------------------------------------------------------------------------
//task8
//int num = Convert.ToInt32(Console.ReadLine());
//while (num % 2 == 0)
//{
//    int secondNum = num / 2;


//}

//---------------------------------------------------------------------------------
//task9

//int num = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//int add = 0;
//while (num % 10 != 0)
//{
//    add = num % 10;
//    sum = add + sum;
//    num /= 10;
//}
//Console.WriteLine(sum);


//---------------------------------------------------------------------------------
//Task10

//int[] arr = { 12, 10, 13, 15, 16, 23,34 };
//int min = arr[0];
//for (int i = 1;i < arr.Length;i++)
//{
//    if (arr[i] < min)
//    min= arr[i];
//}
//Console.WriteLine(min);


//---------------------------------------------------------------------------------
//task11

//int[] arr = { 12, 10, 13, 15, 1, -12, 3 };
//int count = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] > 10)
//        count++;
//}
//Console.WriteLine(count);

//---------------------------------------------------------------------------------
//task12

//int num = 73;
//int teklik = 0;
//int onluq = 0;
//teklik = num % 10;
//onluq = num / 10;
//if (teklik > onluq)
//{
//    Console.WriteLine("teklik boyukdur");
//}
//else if (teklik < onluq)
//{
//    Console.WriteLine("onluq boyukdur");
//}
//else
//{
//    Console.WriteLine("beraberdiler");
//}

//---------------------------------------------------------------------------------
//task13 

//int[] arr = { 12, 14, 13, 15, 93, 19 };
//int max = 0;
//int min = 0;
//for (int i = 1; i < arr.Length; i++)
//{
//    if (arr[i] > arr[max])
//    {
//        max=i;
//    }
//    if (arr[i] < min)
//    { min=i; }

//}
//max = min + max;
//arr[min] = arr[max-min];
//arr[max] = arr[max-min];


//---------------------------------------------------------------------------------
//task14
//int num = Convert.ToInt32(Console.ReadLine());
//int count = 0;
//while (num > 0)
//{
//    num /= 10;
//    count++;
//}
//Console.WriteLine(count);

//---------------------------------------------------------------------------------
//task15

//int num = 1234;
//int mainNum = 0;
//mainNum = (7 * 100000) + (num * 10) + 8;
//Console.WriteLine(mainNum);

//---------------------------------------------------------------------------------
//task16


//int num = 123;
//int mainNum = 0;
//mainNum = num + (num * 1000);
//Console.WriteLine(mainNum);


//---------------------------------------------------------------------------------
//task17

//int num = 123;
//int mainNum = 0;
//int faiz = 7;
//mainNum = (num * 10) + 7;
//mainNum = (mainNum * faiz) / 100;
//Console.WriteLine(mainNum);


//---------------------------------------------------------------------------------
//task18


//int num = Convert.ToInt32(Console.ReadLine());
//if (num % 2 != 0)
//{
//    Console.WriteLine("eded tekdir");
//}
//else if (num == 0)
//{
//    Console.WriteLine("ne tek ne cutdur");
//}
//else {
//    Console.WriteLine("eded cutdur");
//}


//---------------------------------------------------------------------------------
//task19



//int num = Convert.ToInt32(Console.ReadLine());
//if (num %3==0 && num%7==0)
//{
//    Console.WriteLine("3 ve 7-e bolunur");
//}
//else
//{
//    Console.WriteLine("eded 3 ve 7-e bolunmur ");
//}


//---------------------------------------------------------------------------------
//task20


//Console.WriteLine("1-ci ededi daxil edin");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("2ci ededi daxil edin");
//int num2 = Convert.ToInt32(Console.ReadLine());
//int bigNum = 0;
//if (num1 > num2)
//{
//    bigNum= num1;
//}
//else
//{
//    bigNum = num2;
//}
//Console.WriteLine("en boyuy eded="+bigNum);


//---------------------------------------------------------------------------------
//task21


//string[] arr = { "AB-106", "azerbaycan", "qarabag", "novruz", "kicik" };
//string check = "AB-106";
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == check)
//    {
//        Console.WriteLine("AB-106 sozu var");
//        break;
//    }
//    else { Console.WriteLine("AB-106 sozu yoxdur"); }
//    break;
//}

//---------------------------------------------------------------------------------
//task22


//int num1 = 1;
//int num2 = 105;
//int count = 0;
//for (int i = num1;i <= num2;i++)
//{
//    if (i % 15 == 0)
//    {
//        count++;
//    }

//}
//Console.WriteLine(count);

//---------------------------------------------------------------------------------
//task23-by Sabir teacher


//int[] arr = { 21, 5, 2, 13, 15 };
//int[] arr2 = { 1, 6, 13,17, 111 };
//int num = 0;
//for (int i = 0; i < arr2.Length; i++)
//{
//    for (int j = 0; j < arr.Length; j++)
//    {
//        if (arr2[i] == arr[j])
//        {
//            num = arr2[i];

//            Console.WriteLine(num);

//        }

//    }
//}


//---------------------------------------------------------------------------------
//task24

int[] arr ={ -11,-23,5,65,-6,23,44 };
int minNum = 0;
for (int i = 0; i < arr.Length; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] > arr[j])
        {
            minNum = arr[j];
          
            arr[i] = minNum;
        }
    }
    Console.WriteLine(arr[i]);
}

