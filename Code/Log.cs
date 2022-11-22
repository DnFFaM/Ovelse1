
namespace Ovelse1.Code;

public struct Logics
{
    public static double CalculateAge(DateTime dateOfBirthog)
    {
        double age = (double)DateTime.Now.Subtract(dateOfBirthog).TotalDays / 365;

        return Math.Round(age, 0);
    }
}
