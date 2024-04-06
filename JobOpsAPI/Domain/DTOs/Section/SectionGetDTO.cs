﻿using JobOpsAPI.Domain.DTOs.Department;

namespace JobOpsAPI.Domain.DTOs.Section
{
    public class SectionGetDTO
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string DepartmentId { get; set; } = string.Empty;
        public DepartmentGetDTO? Department { get; set; }
    }
}
