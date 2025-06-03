// Collection

using System.Collections;

Random random = new Random();

#region ArrayList
//ArrayList numbers = new ArrayList();
//numbers.Add(random.Next(10, 99));
//numbers.Add(random.NextDouble());
//numbers.Add("Assalamu aleykum");

//for (int i = 0; i < numbers.Count; i++)
//{
//    Console.WriteLine(numbers[i]);
//}



#endregion


#region Stack
//Stack stack = new();
//stack.Push(98);
//stack.Push(44);
//stack.Push(13);
//stack.Push(43);
//Console.WriteLine(stack.Count);
//Console.WriteLine(stack.Pop());
//Console.WriteLine(stack.Count);
#endregion

#region
Queue queue = new Queue();
queue.Enqueue("salam");
queue.Enqueue(1.3);
queue.Enqueue(98);

Console.WriteLine(queue.Count);
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Count);
#endregion