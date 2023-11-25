int errorCount = 0;

if (problem1)
{
    errorCount += 1;

    if (problem2)
    {
        errorCount += 1;
    }

    // Imagine that in a real program there was a big
    // chunk of code here before the following lines.

    int errorCount = GetErrors(); // compiler error
    if (problem3)
    {
        errorCount += 1;
    }
}