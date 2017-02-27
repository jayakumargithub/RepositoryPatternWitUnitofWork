using System;

namespace My.Domain.Interface
{
    interface IUnitOfWork: IDisposable 
    {
        ICourseRepository Courses { get; set; }
        IAuthorRepository Authors { get; set; }

        int Save();
    }
}
