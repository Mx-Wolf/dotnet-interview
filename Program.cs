// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// 1.
{
int a = 5;
object o = a;
var x = (long) o; // распространенный вопрос от новичка о том, что распаковка в чужой тип недоступна.
Console.WriteLine(x.GetType().Name);
}
//***************************************************//
// 2
{
var str = "123";
var newStr = str;
str = newStr + "345";// здесь создается третья строка, и str теперь на нее ссылается. newStr не меняется.
Console.Write(newStr);
}
//***************************************************//
// 3
{
var count = 0;
Enumerable.Repeat(1,100)
.Where((_)=>count<50)
.Select((x)=>count++); //select возвращает IEnumerable<int> и пока перечисление не производится колбэк не вызывается.
Console.Write(count);
}
//***************************************************//
// 4
{
const int iterations = 1000000000;
var count = 0;
Parallel.For(0,iterations, (_)=>count++);
Console.Write($"{count > iterations}, {count < iterations}");
// false, true
}

//***************************************************//
// 5
{
  var actions = new List<Action>();
  for(var count = 0; count<5; count ++){
    actions.Add(()=>Console.Write(count + " "));
  }
  foreach(var action in actions){
    action();
  }
}