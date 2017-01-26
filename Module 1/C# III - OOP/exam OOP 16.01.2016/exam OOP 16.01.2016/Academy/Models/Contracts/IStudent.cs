namespace Academy.Models.Contracts
{
    using Academy.Models.Enums;
    using Academy.Models.Utils.Contracts;
    using System.Collections.Generic;

    public interface IStudent : IUser
    {
        Track Track { get; set; }

        IList<ICourseResult> CourseResults { get; set; }
    }
}
