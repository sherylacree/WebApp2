﻿using System.ComponentModel.DataAnnotations;

namespace WebApp2.Models;

public class Employee
{
    public int Id { get; set; }
    [StringLength(30)]
    public string Email { get; set; } = string.Empty;
    [StringLength(30)]
    public string Password { get; set; } = string.Empty;
}
