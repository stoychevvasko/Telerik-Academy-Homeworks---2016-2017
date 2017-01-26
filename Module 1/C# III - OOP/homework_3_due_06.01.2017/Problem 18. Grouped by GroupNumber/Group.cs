namespace Problem_18
{
    public class Group
    {
        public int GroupNumber { get; set; }
        public string GroupName { get; set; }

        public Group(int num, string name)
        {
            this.GroupNumber = num;
            this.GroupName = name;
        }

        public Group()
            : this(0, "NoName")
        {
        }
    }
}
