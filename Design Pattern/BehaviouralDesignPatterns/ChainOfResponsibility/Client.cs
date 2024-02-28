using ChainOfResponsibility;

public class Client
{
    private Approver supervisor;
    private Approver departmentHead;
    private Approver financeDepartment;
    public Client()
    {
        supervisor = new Supervisor();
        departmentHead = new DepartmentHead();
        financeDepartment = new FinanceDepartment();
        supervisor.SetNextApprover(departmentHead);
        departmentHead.SetNextApprover(financeDepartment);
    }

    public void SubmitRequest(string purpose, double amount)
    {
        supervisor.ProcessRequest(purpose, amount);
    }
}