/*
static void Main(string[] args)
{
    A(); // først kalder vi på A()
}
public static void A()
{
    B(); // Herefter kalder vi på B() først
    C();
}
public static void B()
{
    C(); // efter vi har kaldt på B() kalder vi så på C()
    D();
}
public static void C()
{
    D(); //Efter C() kalder den på D() som fører os til stien herunder, og efter det kommer vi tilbage til C() oppe i A()
    B();
}
public static void D()
{
    //Find stien hertil
}
// Opgave b
static void Main(string[] args)
{
    A(); // <--- 1, 5
}
public static void A()
{
    B(); // <--- 2, 6
    C();
}
public static void B()
{
    C(); // <--- 3
    D();
}
public static void C()
{
    A(); // <--- 4
    B();
}
public static void D()
{
    //Find stien hertil
}
*/