namespace EmployeesCh12.Models
{
    public class DepartmentLocation
    {
        //Composite Primary Key and Foreign Key for Department
        public int DepartmentID { get; set; }
        //composite Primary Key and Foreign Key for Location
        public int LocationID { get; set; }

        //navigation properties
        public Department Department { get; set; } = null!;
        public Location Location { get; set; } = null!;
    }
}
