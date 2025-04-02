namespace Application;

public class Calculate
{
    public int CorrectSum(params int[] args)
    {
        var sum = 0;

        foreach (int arg in args)
            sum += arg;

        return sum;
    }

    public int UnCorrectSum(params int[] args)
    {
        var sum = 0;

        foreach (int arg in args)
            sum += arg;

        return sum + 1;
    }
}
