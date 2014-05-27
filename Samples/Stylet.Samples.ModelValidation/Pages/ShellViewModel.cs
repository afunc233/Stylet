﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stylet.Samples.ModelValidation.Pages
{
    public class ShellViewModel : Conductor<IScreen>
    {
        public ShellViewModel(UserViewModel userViewModel)
        {
            this.DisplayName = "Stylet.Samples.ModelValidation";

            this.ActiveItem = userViewModel;
        }
    }
}
