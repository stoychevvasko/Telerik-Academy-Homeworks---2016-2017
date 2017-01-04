namespace Problem_16
{
    public class Group
    {
        /// <summary>
        /// Represents a group number for <see cref="Problem_16.Group"/> objects.
        /// </summary>
        public int GroupNumber { get; set; }

        /// <summary>
        /// Represents a department for <see cref="Problem_16.Group"/> objects.
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// Represents a group ID for <see cref="Problem_16.Group"/> objects.
        /// </summary>
        public int ID { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupC"/> class.
        /// </summary>
        /// <param name="groupNumber">Group number parameter.</param>
        /// <param name="department">Department parameter.</param>
        /// <param name="id">Group ID parameter.</param>
        public Group(int groupNumber, string department, int id)
        {
            this.GroupNumber = groupNumber;
            this.Department = department;
            this.ID = id;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupC"/> class.
        /// </summary>
        public Group()
            : this(0, "NoNameDepartment", 0)
        {
        }
        
    }
}
