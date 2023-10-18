namespace Human
{
        public abstract class Human
        {
            public virtual int Id { get; set; }
            public virtual string? Name { get; set; }
            public virtual string? LastName { get; set; }
            public abstract string Position { get; }
            public virtual double? Salary { get; set; }

        }
        public class Employee : Human
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? LastName { get; set; }
            public double? Salary { get; set; }
            public override string Position => "Employee";
        }
        public class Manager : Human
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? LastName { get; set; }
            public double? Salary { get; set; }
            public override string Position => "Manager";
        }
}  