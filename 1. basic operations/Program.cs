
 int[] parameters =Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();

int pushElem = parameters[0];
int popElem = parameters[1];
int searchElem  = parameters[2];

var stack = new Stack<int>(values.Take(pushElem));

while (popElem>0 & stack.Count > 0) 
{ stack.Pop();
    popElem--;
}

if (stack.Count == 0)
{ Console.WriteLine("0"); }

else if (stack.Contains(searchElem)) { Console.WriteLine("true"); }
else Console.WriteLine(stack.Min()); 