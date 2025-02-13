﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesWebSite.Pages
{
    public class TryValidateModelPageModel : PageModel
    {
        [ModelBinder]
        public UserModel UserModel { get; set; }

        public bool Validate { get; set; }

        public void OnPost(UserModel user)
        {
            Validate = TryValidateModel(user);
        }
    }
}
