int foo1(int x);

int
bar(int x)
{
  return foo1(x) + 100;
}
