// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SER_ServerAPPBlazer.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\anaci\source\repos\SER_ServerAPPBlazer\SER_ServerAPPBlazer\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\anaci\source\repos\SER_ServerAPPBlazer\SER_ServerAPPBlazer\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\anaci\source\repos\SER_ServerAPPBlazer\SER_ServerAPPBlazer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\anaci\source\repos\SER_ServerAPPBlazer\SER_ServerAPPBlazer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\anaci\source\repos\SER_ServerAPPBlazer\SER_ServerAPPBlazer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\anaci\source\repos\SER_ServerAPPBlazer\SER_ServerAPPBlazer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\anaci\source\repos\SER_ServerAPPBlazer\SER_ServerAPPBlazer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\anaci\source\repos\SER_ServerAPPBlazer\SER_ServerAPPBlazer\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\anaci\source\repos\SER_ServerAPPBlazer\SER_ServerAPPBlazer\_Imports.razor"
using SER_ServerAPPBlazer

#nullable disable
    ;
#nullable restore
#line 10 "C:\Users\anaci\source\repos\SER_ServerAPPBlazer\SER_ServerAPPBlazer\_Imports.razor"
using SER_ServerAPPBlazer.Shared

#nullable disable
    ;
#nullable restore
#line 1 "C:\Users\anaci\source\repos\SER_ServerAPPBlazer\SER_ServerAPPBlazer\Pages\Personnal.razor"
 using System.Text.Json

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 2 "C:\Users\anaci\source\repos\SER_ServerAPPBlazer\SER_ServerAPPBlazer\Pages\Personnal.razor"
      "/Personnal"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class Personnal : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\anaci\source\repos\SER_ServerAPPBlazer\SER_ServerAPPBlazer\Pages\Personnal.razor"
       

    public class PersonnalClass
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public string ProffesionalCategory { get; set; }
    }

    string _ApiUrl = "http://localhost:5031/";
    private IEnumerable<PersonnalClass> personas = Array.Empty<PersonnalClass>();
    private async Task refreshList()
    {
        HttpClient httpClient = new HttpClient();
        HttpResponseMessage responce = await httpClient.GetAsync(_ApiUrl + "api/Base/GetPersonnal");
        httpClient.Dispose();
        using var respoceStream = await responce.Content.ReadAsStreamAsync();
        personas = await JsonSerializer.DeserializeAsync<IEnumerable<PersonnalClass>>(respoceStream);
    } 

    protected override async Task OnInitializedAsync()
    {
        await this.refreshList();
    }


#line default
#line hidden
#nullable disable

    }
}
#pragma warning restore 1591