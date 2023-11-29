﻿namespace Project2.DTOs
{
    public class MarketerModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int phoneNumber { get; set; }
        public string password { get; set; }
        public string ConfirmPassword { get; set; }
        public int AddressId { get; set; }
        public AddressModel Address { get; set; }
    }
}
