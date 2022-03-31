OperationFacade operationFacade = new OperationFacade();

operationFacade.addingOperation(10, 2);

operationFacade.divisionOperation(10, 2);

public interface IOperation
{
    void answerIs(int firstNumber, int secondNumber);
}

public class AddingOperation : IOperation
{
    public void answerIs(int firstNumber, int secondNumber)
    {
        Console.WriteLine(firstNumber + secondNumber);
    }
}

public class DivisionOperation : IOperation
{
    public void answerIs(int firstNumber, int secondNumber)
    {
        double answer = firstNumber / secondNumber;

        Console.WriteLine(answer);  
       
    }
}

public class OperationFacade
{
    private IOperation _addingOperation;
    private IOperation _divisionOperation;

    public OperationFacade()
    {
        _addingOperation = new AddingOperation();
        _divisionOperation = new DivisionOperation();
    }

    public void addingOperation(int firstNumber,int secondNumber)
    {
        _addingOperation.answerIs(firstNumber, secondNumber);
    }

    public void divisionOperation(int firstNumber, int secondNumber)
    {
        _divisionOperation.answerIs(firstNumber, secondNumber);
    }
}
