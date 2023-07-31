var p = new Pair<string, int>("asd", 1);
var q = new ComparablePair<string, int>("zxc", 2);
var result = q.CompareTo(p);

if (result == 1)
{
    Console.WriteLine("q больше p");
}
else if (result == 0)
{
    Console.WriteLine("q равна p");
}
else
{
    Console.WriteLine("q меньше  p");
}