namespace DockerCalculator;

public class Calculator : ICalculator
{
    public double Add(double n1, double n2)
    {
        double result = n1 + n2;
        LogOperation(n1, n2, "Plus", result);
        return result;
    }

    public double Subtract(double n1, double n2)
    {
        double result = n1 - n2;
        LogOperation(n1, n2, "Minus", result);
        return result;
    }


    public double Multiply(double n1, double n2)
    {
        double result = n1 * n2;
        LogOperation(n1, n2, "Multiply", result);
        return result;
    }
    
    public double Divide(double n1, double n2)
    {
        double result = n1 / n2;
        LogOperation(n1, n2, "Divide", result);
        return result;
    }


    private void LogOperation(double n1, double n2, string operation, double result)
    {
        using (var db = new AppDbContext())
        {
            var calculationLog = new CalculationLog
            {
                Number1 = n1,
                Number2 = n2,
                Operation = operation,
                Result = result
            };

            db.CalculationLogs.Add(calculationLog);
            db.SaveChanges();
        }
    }
}

