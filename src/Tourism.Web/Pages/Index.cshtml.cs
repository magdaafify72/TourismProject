﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Tourism.Web.Pages;

public class IndexModel : TourismPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
