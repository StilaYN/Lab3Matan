using System;
using System.Reflection;
using MatrixSolveMethod;
public class SmoothingMethod
{
    private float[] _xValue;
    private float[] _yValue;
    private float[,] _coefficient;
    private int _degree;

    public SmoothingMethod(float[] xValue, float[] yValue, int degree)
    {
        if (xValue.Length != yValue.Length) throw new ArgumentException("different array lengths");
        _xValue = xValue;
        _yValue = yValue;
        _degree = degree+1;
        FindCoefficient();
    }

    public float GetFunctionValue(float value)
    {
        float x = 0;
        for (int i = 0; i < _degree; i++)
        {
            x += _coefficient[i, 0]*(float)Math.Pow(value, i);
        }
        return x;
    }
    public float GetFunctionValue(float value,int degree, float[] coefficient) {
        float x = 0;
        for (int i = 0; i < degree+1; i++)
        {
            x += coefficient[i] * (float)Math.Pow(value, i);
        }
        return x;
    }
    private void FindCoefficient()
    {
        var coeff = new float[_degree, _degree];
        var beta = new float[_degree, 1];
        FillMatrix(coeff,beta);
        GaussianMethodWithMainElement method = new GaussianMethodWithMainElement();
        _coefficient = method.FindRoot(coeff, beta);
    }

    private void FillMatrix(float[,]coeff,float[,]beta)
    {
        for (int i = 0; i < _degree; i++)
        {
            for (int j = 0; j < _degree; j++)
            {
                float c = 0;
                for (int k = 0; k < _xValue.Length; k++)
                {
                    c += (float)Math.Pow(_xValue[k], j+i);
                }
                coeff[i, j] = c;
            }
            float d = 0;
            for (int j = 0; j < _yValue.Length; j++)
            {
                d += _yValue[j] * (float)Math.Pow(_xValue[j], i);
            }
            beta[i, 0] = d;
        }
    }
    
}