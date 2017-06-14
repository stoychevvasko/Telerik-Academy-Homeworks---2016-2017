namespace SchoolSystem.Framework.Models.Contracts
{
    public interface ISchool : IGetStudent, IGetTeacher, IAddStudent, IAddTeacher, IRemoveStudent, IRemoveTeacher, IGetStudentAndTeacher
    {
    }
}
