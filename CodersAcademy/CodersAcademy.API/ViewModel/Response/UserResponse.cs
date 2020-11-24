using System;

namespace CodersAcademy.API.ViewModel.Response
{
    public class UserResponse
    {
        public Guid Id { get; set; }

        public String Name { get; set; }

        public String Email { get; set; }

        public String Photo { get; set; }
    }
}
