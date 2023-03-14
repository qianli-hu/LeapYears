using System;
using System.Linq;

/*The Revised Julian Calendar is a calendar system very similar to the familiar Gregorian Calendar,
but slightly more accurate in terms of average year length.
The Revised Julian Calendar has a leap day on Feb 29th of leap years as follows:
Years that are evenly divisible by 4 are leap years.
Exception: Years that are evenly divisible by 100 are not leap years.
Exception to the exception: Years for which the remainder when divided by 900 is
either 200 or 600 are leap years.
For instance, 2000 is an exception to the exception: the remainder when dividing 2000 by 900 is 200. 
    So 2000 is a leap year in the Revised Julian Calendar.
    Given two positive year numbers(with the second one greater than or equal to the first),
    find out how many leap days(Feb 29ths) appear between Jan 1 of the first year, 
    and Jan 1 of the second year in the Revised Julian Calendar.This is equivalent 
    to asking how many leap years there are in the interval between the two years, 
    including the first but excluding the second.*/

class Program{
    static void Main(string[] args)
    {
        Console.Write("Enter the first year: ");
        int year1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second year: ");
        int year2 = int.Parse(Console.ReadLine());

        int leapYearCount = 0;
        YearService yearService= new YearService();

        for (int year = year1; year <= year2; year++)
        {
            leapYearCount += yearService.IsLeapYear(year) ? 1 : 0;
        }

        Console.Write($"Total Number of Leap Year is {leapYearCount}");
        Console.ReadKey();


    }
}


public interface IYearService
{
    // Input: year, output: boolean value to see if the year is leapyear
    public bool IsLeapYear(int year);
}

public class YearService: IYearService
{
    public bool IsLeapYear(int year)
    {
        if (year % 4 == 0 && (year % 100 != 0 || year % 900 == 200 || year % 900 == 600))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}