﻿using JobOpsAPI.DataAccess.Context;
using JobOpsAPI.DataAccess.Repositories.Interfaces;
using JobOpsAPI.Domain.Entities;

namespace JobOpsAPI.DataAccess.Repositories.Implementations
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        private readonly JobOpsDbContext _context;

        public DepartmentRepository(JobOpsDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Department>? GetByPageNumber(int page, int pageSize)
        {
            try
            {
                var departments = _context.Departments
                    .Where(d => d.DeletedOn == null)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                return departments;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int GetDataCount()
        {
            try
            {
                int count = _context.Departments
                    .Where(d => d.DeletedOn == null)
                    .ToList()
                    .Count();

                return count;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}