namespace EvaluationApp.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(Employee employee);
        IEnumerable<Employee> GetAllEmployee();
        Employee Add(Employee employee);

        Employee GetEmployeeById(int id);
        Employee Update(Employee employeeChanges);

        Employee Delete(int id);
        Skill GetSkill(int id);
        IEnumerable<Skill> GetAllSkill();

        void AddSkill(Skill skill);

        void DeleteSkill(int id);
    }
}
