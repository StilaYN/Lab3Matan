using System;


public class LagrangeInterpolationMethod
{
    private float[] _xValue;
    private float[] _yValue;

    public LagrangeInterpolationMethod(float[] xValue, float[] yValue)
    {
        if (xValue.Length != yValue.Length) throw new ArgumentException("different array lengths");
        _xValue = xValue;
        _yValue = yValue;
    }

    public float GetFunctionValue(float value)
    {
        float x=0;
        for (int i = 0; i < _xValue.Length; i++)
        {
            float composition = _yValue[i];
            for (int j = 0; j < _xValue.Length; j++)
            {
                if (i != j) composition *= ((value - _xValue[j]) / (_xValue[i] - _xValue[j]));
            }
            x += composition;
        }
        return x;
    }
}