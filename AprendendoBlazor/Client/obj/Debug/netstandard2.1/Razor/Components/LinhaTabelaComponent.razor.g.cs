#pragma checksum "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\Components\LinhaTabelaComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "624a7ee61295d7521e7a3e75cc69c8c294829af6"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group mx-sm-3 mb-2");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "td");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "checkbox");
            __builder.AddAttribute(7, "class", "form-check-input");
            __builder.AddAttribute(8, "id", "checked");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\Components\LinhaTabelaComponent.razor"
                                                                                                         () => AtualizaUsuario.InvokeAsync(Usuario)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\Components\LinhaTabelaComponent.razor"
                                                                            Usuario.Checked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Usuario.Checked = __value, Usuario.Checked));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 9 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\Components\LinhaTabelaComponent.razor"
 foreach(var member in memberInfo)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\Components\LinhaTabelaComponent.razor"
     if (member.MemberType == MemberTypes.Property &&
                !ColunasParaExcluirCSV.Contains(member.Name, StringComparison.OrdinalIgnoreCase))
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "        ");
            __builder.OpenElement(16, "td");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.AddContent(18, 
#nullable restore
#line 15 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\Components\LinhaTabelaComponent.razor"
             Usuario.GetType().GetProperty(member.Name).GetValue(Usuario).ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, ";\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 17 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\Components\LinhaTabelaComponent.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\Components\LinhaTabelaComponent.razor"
     
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(21, "<br>");
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
