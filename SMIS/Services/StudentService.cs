using Microsoft.EntityFrameworkCore;
using SMIS.Models;

namespace SMIS.Services
{
    public class StudentService
    {
        private readonly SmisDbContext dbContext;

        public StudentService(SmisDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task CreateStudentAsync(Student student)
        {
            await this.dbContext.Students.AddAsync(student);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await this.dbContext.Students.ToListAsync();
        }
    }
}
