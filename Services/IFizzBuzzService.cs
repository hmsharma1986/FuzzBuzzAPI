﻿namespace FizzBuzzApi.Services
{
    public interface IFizzBuzzService
    {
        (List<string> Results, List<string> Divisions) ProcessValues(int[] values);
    }
}
