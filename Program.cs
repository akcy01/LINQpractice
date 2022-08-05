using System;
using LINQ.Tests;
public class Program
{
    public static void Main(string[] args)
    {
        /* LINQ Aggregation işlemleri */
        AggregattionTest deneme = new AggregattionTest();
        deneme._Average(); 
        deneme._Max(); 
        deneme._Min(); 
        deneme._Sum(); 

        /* LINQ Conversion Işlemleri */ 
        ConversionTest convTest = new ConversionTest();
        convTest._OfType();
        convTest._ToDictionary();
        convTest._ToLookUp();

        /* LINQ Element Işlemleri */
        ElementTest elmTest = new ElementTest();
        elmTest._First();
        elmTest._FirstOrDefault();
        elmTest._Last();
        elmTest._LastOrDefault();
        elmTest._Single();
        elmTest._SingleOrDefault();

        /* LINQ Grouping Işlemleri */
        GroupingTest grpTest = new GroupingTest();
        grpTest._GroupBy();

        /* LINQ Join Işlemleri */
        JoinTest joinTest = new JoinTest();
        
        /* LINQ Ordering Işlemleri */
        OrderingTest ordTest = new OrderingTest();
        ordTest._OrderBy();
        ordTest._OrderByDescending();
        ordTest._Reverse();
    }
}