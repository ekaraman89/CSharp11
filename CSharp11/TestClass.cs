namespace CSharp11
{
    #region class

    public class PersonClass
    {
        public string FirstName { get; }
        public string MiddleName { get; }
        public string LastName { get; }

        public PersonClass(string firstName, string lastName, string? middleName = null)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName ?? string.Empty;
        }
    }

    public class StudentClass : PersonClass
    {
        public int ID { get; }

        public StudentClass(int id, string firstName, string lastName, string? middleName = null)
            : base(firstName, lastName, middleName)
        {
            ID = id;
        }
    }

    #endregion class

    #region record

    record PersonRecord(string FirstName, string LastName, string MiddleName = "");
    record StudentRecord(int ID, string FirstName, string LastName, string MiddleName = "") : PersonRecord(FirstName, LastName, MiddleName);

    #endregion record

    #region record v2

    record PersonRecord2()
    {
        public required string FirstName { get; init; }
        public string MiddleName { get; init; }
        public required string LastName { get; init; }
    }
    record StudentRecord2(int ID) : PersonRecord2
    {
    }

    #endregion record v2
}