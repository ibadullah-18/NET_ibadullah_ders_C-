// Proxy pattern

/*
    1. Protection proxy 
    2. Virtual proxy (Lazy intilization)
    3. Remote proxy (Remote object)
    4. Logging proxy 
    5. Cashing proxy 
*/


// Protection Proxy Example

using System.Security.Principal;

interface IOperation
{
    void Request();

}

// Real subject

class RealOperationSubject : IOperation
{
    public void Request()
    {
        Console.WriteLine("Some real operation.");
    }
}

// Proxy

class OperationProxy : IOperation
{

    private IOperation _operation { get; set; }
    private ReaderWriterLock _role { get; set; }
    public OperationProxy(IOperation operation , int role)
    {
        _operation = operation;
        _role = role;
    }
    public void Request()
    {
      
    }
}