// ===============================
// roberto.garcia@transmaquila.com
// www.transmaquila.com
// ===============================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace ASCA.Pro.ViewModels
{
    public class UserEditViewModel : UserViewModel
    {
        public string CurrentPassword { get; set; }

        [MinLength(6, ErrorMessage = "New Password must be at least 6 characters")]
        public string NewPassword { get; set; }
        new private bool IsLockedOut { get; } //Hide base member
    }
}
