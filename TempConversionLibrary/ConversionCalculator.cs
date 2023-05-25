namespace TempConversionLibrary;

public class ConversionCalculator
{
    public ConversionCalculator(float baseTemp, char baseScaleName)
    {
        BaseTemp = baseTemp;
        BaseScaleName = baseScaleName;
    }

    public float ToFahrenheight()
    {
        float computedTemp = -10000;
        switch(BaseScaleName)
        {
            case 'F':
                computedTemp = BaseTemp;
                break;

            case 'C':
                computedTemp = BaseTemp * 9 / 5 + 32;
                break;

            case 'K':
                computedTemp = (BaseTemp - 273) * 9 / 5 + 32;
                break;
        }
        return computedTemp;
    }

    public float ToCelsius()
    {
        float computedTemp = -10000;
        switch (BaseScaleName)
        {
            case 'C':
                computedTemp = BaseTemp;
                break;

            case 'F':
                computedTemp = (BaseTemp - 32) * 5 / 9;
                break;

            case 'K':
                computedTemp = BaseTemp - 273;
                break;
        }
        return computedTemp;
    }

    public float ToKelvin()
    {
        float computedTemp = -10000;
        switch (BaseScaleName)
        {
            case 'K':
                computedTemp = BaseTemp;
                break;

            case 'C':
                computedTemp = BaseTemp + 273;
                break;

            case 'F':
                computedTemp = (BaseTemp - 32) * 5 / 9 + 273;
                break;
        }
        return computedTemp;
    }


    public float BaseTemp { get; set; }
    public char BaseScaleName { get; set; }


    /*
     This placeholder initialization is commonly used in programming as a convention to handle exceptional 
    or error conditions. It serves as a reminder to handle cases where the expected value is not assigned
    or computed correctly.



     */

}
