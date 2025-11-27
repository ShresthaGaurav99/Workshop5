class Program
{
    static void Main(string[] args)
    {
        // TASK 1
        BankAccount acc = new BankAccount("ACC101", 500);
        Console.WriteLine(acc.AccountNumber);
        acc.Deposit(200);
        acc.Withdraw(100);
        Console.WriteLine("Balance: " + acc.Balance);

        // TASK 2
        Car car = new Car { Brand = "Toyota", Speed = 120, Seats = 5 };
        Motorcycle bike = new Motorcycle { Brand = "Yamaha", Speed = 90, Type = "Sports" };
        car.DisplayInfo();
        bike.DisplayInfo();

        // TASK 3 (overloading)
        Printer p = new Printer();
        p.Print("Hello");
        p.Print(55);
        p.Print("Repeat", 3);

        // TASK 3 (overriding)
        Teacher t1 = new NepaliTeacher();
        Teacher t2 = new EnglishTeacher();
        t1.Teaching();
        t2.Teaching();
        t1.SalaryInfo();

        // TASK 4
        AbsCar ac = new AbsCar();
        AbsBike ab = new AbsBike();
        ac.Display(); ac.StartEngine(); ac.StopEngine();
        ab.Display(); ab.StartEngine(); ab.StopEngine();

        // TASK 5
        ElectronicsStore store = new ElectronicsStore();
        Laptop lap = new Laptop("Dell", 800);
        Smartphone ph = new Smartphone("Samsung", 600);

        store.AddDevice(lap);
        store.AddDevice(ph);
        store.ShowAllDeviceDetails();
    }
}
