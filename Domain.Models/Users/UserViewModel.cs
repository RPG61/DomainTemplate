using System;
using Domain.Models.POCOs;

namespace Domain.Models.ViewModels
{
    public class UserViewModel : User
    {
        public static explicit operator UserViewModel(Movie v)
        {
            throw new NotImplementedException();
        }
    }
}
