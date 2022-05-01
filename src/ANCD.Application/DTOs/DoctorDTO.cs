﻿namespace ANCD.Application.DTOs
{
    public sealed record DoctorDTO
    {
        public Guid Id { get; init; }

        public string Name { get; init; }

        public string Email { get; init; }

        public string CRM { get; init; }
    }
}
