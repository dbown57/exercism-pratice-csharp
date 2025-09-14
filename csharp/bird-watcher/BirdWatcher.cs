class BirdCount(int[] birdsPerDay)
{
    private readonly int[] birdsPerDay = birdsPerDay;

    public static int[] LastWeek()
    {
        return [0, 2, 5, 3, 7, 8, 4];
    }

    public int Today()
    {
        return birdsPerDay.LastOrDefault();
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1] = Today() + 1;
    }

    public bool HasDayWithoutBirds()
    {
        return birdsPerDay.Contains(0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        return birdsPerDay.Take(numberOfDays).Sum();
    }

    public int BusyDays()
    {
        return birdsPerDay.Count(birdsCount => birdsCount >= 5);
    }
}
