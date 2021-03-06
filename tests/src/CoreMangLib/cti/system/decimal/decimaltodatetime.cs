using System;
using System.Globalization;
/// <summary>
///System.IConvertible.ToDateTime(System.IFormatProvider)
/// </summary>
public class DecimalToDateTime
{
    #region Public Methods
    public bool RunTests()
    {
        bool retVal = true;

        TestLibrary.TestFramework.LogInformation("[Negtive]");
        retVal = NegTest1() && retVal;
        return retVal;
    }

    #region Positive Test Cases


    public bool NegTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("NegTest1: Check a Decimal which is  decimal.MaxValue.");

        try
        {
            Decimal i1 = decimal.MaxValue;
            CultureInfo myCulture = CultureInfo.InvariantCulture;
            DateTime  actualValue = ((IConvertible)i1).ToDateTime(myCulture);
            TestLibrary.TestFramework.LogError("101.1", "InvalidCastException should be caught. ");
            retVal = false;
        }
        catch (InvalidCastException)
        {

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("101.2", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }


    #endregion

    #endregion

    public static int Main()
    {
        DecimalToDateTime test = new DecimalToDateTime();

        TestLibrary.TestFramework.BeginTestCase("DecimalToDateTime");

        if (test.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }

}
