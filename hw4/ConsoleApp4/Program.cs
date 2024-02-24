// See https://aka.ms/new-console-template for more information

using ConsoleApp4;
using ConsoleApp4.PracticeGenerics;

// Console.WriteLine("Generic HW");
// List<string> strs = new List<string>();
// strs.Add("string1");
// strs.Add("string12");
// strs.Add("string123");
// Console.WriteLine(string.Join(" ", strs));
// strs.RemoveAt(1); 
// strs.Remove("string1"); // not found, list remain not changed
// Console.WriteLine(string.Join(" ", strs)); 
//
// Console.WriteLine(GenericExample<int, string>.Equal(3, "4"));


// MyStack<int> ms = new MyStack<int>();
// Console.WriteLine(ms.Count());
// ms.Push(2);
// ms.Push(2);
// Console.WriteLine(ms.Count());
// Console.WriteLine(ms.Pop());
// Console.WriteLine(ms.Count());

MyList<int> ml = new MyList<int>();
ml.Add(1);
ml.Add(2);
ml.Add(3);
ml.Add(4);

ml.Print();
Console.WriteLine(ml.Contains(4));
Console.WriteLine(ml.Contains(5));
ml.InsertAt(1, 2);
ml.Print();
ml.DeleteAt(0);
ml.Print();
int t = ml.Remove();
Console.WriteLine(t);
ml.Print();
Console.WriteLine(ml.Find(2));
ml.Clear();
ml.Print();