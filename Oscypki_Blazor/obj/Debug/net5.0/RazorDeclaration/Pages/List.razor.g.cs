// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Oscypki_Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\dev\Oscypki_Blazor\Oscypki_Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\Oscypki_Blazor\Oscypki_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\dev\Oscypki_Blazor\Oscypki_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\dev\Oscypki_Blazor\Oscypki_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\dev\Oscypki_Blazor\Oscypki_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\dev\Oscypki_Blazor\Oscypki_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\dev\Oscypki_Blazor\Oscypki_Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\dev\Oscypki_Blazor\Oscypki_Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\dev\Oscypki_Blazor\Oscypki_Blazor\_Imports.razor"
using Oscypki_Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\dev\Oscypki_Blazor\Oscypki_Blazor\_Imports.razor"
using Oscypki_Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\dev\Oscypki_Blazor\Oscypki_Blazor\_Imports.razor"
using Oscypki_Blazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\dev\Oscypki_Blazor\Oscypki_Blazor\_Imports.razor"
using Oscypki_Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\dev\Oscypki_Blazor\Oscypki_Blazor\_Imports.razor"
using Oscypki_Blazor.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/List")]
    public partial class List : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\dev\Oscypki_Blazor\Oscypki_Blazor\Pages\List.razor"
       

    IEnumerable<Oscypki> oscypki;

    protected override async Task OnInitializedAsync()
    {
        oscypki = _MockOscypekRepository.GetAllOscypki();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOscypekRepository _MockOscypekRepository { get; set; }
    }
}
#pragma warning restore 1591