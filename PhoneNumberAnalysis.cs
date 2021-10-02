using System;


public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {

        return
            (string.Compare("212", 0, phoneNumber, 0, 3) == 0,
                string.Compare("555", 0, phoneNumber, 4, 3) == 0,
                phoneNumber.Substring(phoneNumber.Length-4));
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {

    }
}