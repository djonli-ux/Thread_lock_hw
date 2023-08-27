

int x = 0;
object locker = new Object();

for (int i = 1; i <= 5; ++i) 
{
    Thread t = new Thread(Print);
    t.Name = $"thread_{i}";
    t.Start();
}
void Print() 
{
    lock (locker) 
    { 
        x = 1;
        for (int i = 1; i <= 10; ++i)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
            x++;
            Thread.Sleep(500);
            }
        }
}



