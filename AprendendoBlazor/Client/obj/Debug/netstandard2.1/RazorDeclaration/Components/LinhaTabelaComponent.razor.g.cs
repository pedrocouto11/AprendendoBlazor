// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AprendendoBlazor.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\_Imports.razor"
using AprendendoBlazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\_Imports.razor"
using AprendendoBlazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\_Imports.razor"
using AprendendoBlazor.Shared.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\_Imports.razor"
using AprendendoBlazor.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\_Imports.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
    public partial class LinhaTabelaComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\Components\LinhaTabelaComponent.razor"
       

    [Parameter]
    public Usuario Usuario { get; set; }

    [Parameter]
    public string ColunasParaExcluirCSV { get; set; }

    MemberInfo[] memberInfo;

    [Parameter]
    public EventCallback<Usuario> AtualizaUsuario { get; set; }

    private void ChamaCallback()
    {
        Console.WriteLine($"Chamando callback passando o usuario: {0}", Usuario.Nome);
        AtualizaUsuario.InvokeAsync(Usuario);

    }


    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        if (Usuario != null)
        {
            Type typeofItem = Usuario.GetType();
            memberInfo = typeofItem.GetMembers();
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
