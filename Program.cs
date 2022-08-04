﻿using System;
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
    }
}