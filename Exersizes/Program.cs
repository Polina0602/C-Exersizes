using Exersizes.Tasks;

//Console.WriteLine("Your sum is: ");
//var sum = double.Parse(Console.ReadLine());

//DepositInerest.CountInterest(sum);

//Switch.ChooseOne();

//DepositInerest.Percents();

//Multi_Table.MT();

//WhileWithoutEnd.Multi_Numbers();

//w3resourses.Frequency();

int[] a = new int[] { 1, 2, 5, 8 };
int[] b = new int[] { 2, 5 };

//codewars.CoprimeNumbers(15, 10);

//delegate CodeBlog
//youtube stockExchangeMonitor = new youtube();
//stockExchangeMonitor.PriceChangeHandler = ShowPrice;
//stockExchangeMonitor.Start();

//static void ShowPrice(int price)
//{
//    Console.WriteLine($"New price is: {price}");
//}

//events CodeBlog
DateTime time = new DateTime(2022, 6, 14, 23, 13, 7);
DateTime timeToSleep = new DateTime(2022, 6, 14, 4, 13, 7);

Person person = new Person();
person.Name = "Jack";
person.GotoSleep += Person_GotoSleep;
person.Coding += Person_Coding;
person.TakeTime(time);
person.TakeTime(timeToSleep);

static void Person_GotoSleep()
{
    Console.WriteLine("Jack go to sleep");

}

static void Person_Coding(object Sender, EventArgs e)
{
    if (Sender is Person)
    {
        Console.WriteLine($"{((Person)Sender).Name} is coding");
    }

}


//It doesn't work because it's not windows form
//static void operate_ButtonPressedEvent()
//{
//    Haim.Operate operate = new Haim.Operate();
//    operate.Init();

//}