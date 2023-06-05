using System;
using System.Collections.Generic;

namespace WpfApp1.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Surname { get; set; }

    public string? Name { get; set; }

    public string? Fathername { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public int? Role { get; set; }

    public virtual Role? RoleNavigation { get; set; }
}
