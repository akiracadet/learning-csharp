/*
    The following program will cause an
    error as the thisWillNotWork variable
    inside the AnUncompilableMethod is out of
    scope. You may have declared the variable
    in the SomeMethod but that has its own scope
    which is determined inside the curly braces {}
*/

static void SomeMethod()
{
    int thisWillNotWork = 42;
}

static void AnUncompilableMethod()
{
    Console.WriteLine(thisWillNotWork);
}