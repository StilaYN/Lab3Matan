using System;
using System.Collections.Generic;


public class NewtownInterpolationMethod
{
    private Dictionary<int, List<float>> _separatedDifferences = new Dictionary<int, List<float>>();
    private float[] _xValue;
    private float[] _yValue;

    public NewtownInterpolationMethod(float[] xValue, float[] yValue)
    {
        if (xValue.Length != yValue.Length) throw new ArgumentException("different array lengths");
        _xValue = xValue;
        _yValue = yValue;
        GenerateSeparatedDifferences();
    }

    private void GenerateSeparatedDifferences()
    {
        var list = new List<float>();
        foreach (var i in _yValue) list.Add(i);
        _separatedDifferences[0] = list;
        for (int i = 1; i < _xValue.Length; i++)
        {
            var subList = new List<float>();
            for (int j = 0; j < _separatedDifferences[i - 1].Count - 1; j++)
                subList.Add((_separatedDifferences[i - 1][j] - _separatedDifferences[i - 1][j + 1]) / (_xValue[j] - _xValue[j + i]));
            _separatedDifferences[i] = subList;
        }

    }

    public float GetFunctionValue(float value)
    {
        float summ = 0;
        for (int i = 0; i < _xValue.Length; i++)
        {
            float composition = _separatedDifferences[i][0];
            for (int j = 0; j < i; j++)
            {
                composition *= (value - _xValue[j]);
            }
            summ += composition;
        }

        return summ;
    }
}