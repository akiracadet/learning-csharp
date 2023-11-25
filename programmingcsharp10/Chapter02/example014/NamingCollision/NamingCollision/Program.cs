int someValue = GetValue();

if (someValue > 100)
{
    // the following line below will cause an error
    // becase we have declared the variable with
    // the same name below
    // C# handles it this way to prevent ambiguity
    // by disallowing code where one name might refer
    // to more than one thing
    int anotherValue = someValue - 100;
}

// the same variable name
int anotherValue = 123;