using System.Runtime.InteropServices;

StringQueue sq = new StringQueue();

Console.WriteLine(sq.Dequeue());
Console.WriteLine(sq.Peek());

sq.Enqueue("lisäys1");

sq.Enqueue("lisäys2");

sq.Enqueue("lisäys3");

Console.WriteLine(sq.Dequeue());

Console.WriteLine(sq.Peek());

sq.Print();

Console.WriteLine(sq.Count);

sq.Enqueue("lisäys4");

sq.Print();

Console.WriteLine(sq.Count);