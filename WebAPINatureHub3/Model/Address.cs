﻿using System;
using System.Collections.Generic;

namespace WebAPINatureHub3.Models;

public partial class Address
{
    public int AddressId { get; set; }

    public int UserId { get; set; }

    public string? Street { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? ZipCode { get; set; }

    public virtual User User { get; set; } = null!;
}
