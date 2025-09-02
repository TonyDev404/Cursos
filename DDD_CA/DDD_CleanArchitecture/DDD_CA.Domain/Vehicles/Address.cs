﻿namespace DDD_CA.Domain.Vehicles;

public record Address(
    string? Street,
    string? Department,
    string? Province,
    string? City,
    string? Country
);