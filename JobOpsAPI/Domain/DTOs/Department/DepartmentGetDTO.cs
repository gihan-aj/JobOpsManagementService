﻿namespace JobOpsAPI.Domain.DTOs.Department
{
    public class DepartmentGetDTO
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public bool Status { get; set; } = false;
    }
}
