#pragma checksum "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\Components\NovoUsuarioForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97277b73ea488231f11761d36a267681eb866834"
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
    public partial class NovoUsuarioForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Novo Usuario</h3>\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\Components\NovoUsuarioForm.razor"
                 Usuario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 4 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\Components\NovoUsuarioForm.razor"
                                           () => Salvar.InvokeAsync(Usuario)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.AddMarkupContent(13, "<label for=\"Nome\">Nome</label>\r\n        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\Components\NovoUsuarioForm.razor"
                                                          Usuario.Nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Usuario.Nome = __value, Usuario.Nome))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Usuario.Nome));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n            ");
                __Blazor.AprendendoBlazor.Client.Components.NovoUsuarioForm.TypeInference.CreateValidationMessage_0(__builder2, 22, 23, 
#nullable restore
#line 12 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\Components\NovoUsuarioForm.razor"
                                      () => Usuario.Nome

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n\r\n    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.AddMarkupContent(30, "<label for=\"Nome\">Nome</label>\r\n        ");
                __builder2.OpenElement(31, "div");
                __builder2.AddMarkupContent(32, "\r\n            ");
                __Blazor.AprendendoBlazor.Client.Components.NovoUsuarioForm.TypeInference.CreateInputDate_1(__builder2, 33, 34, "form-control", 35, 
#nullable restore
#line 19 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\Components\NovoUsuarioForm.razor"
                                                          Usuario.DataNascimento

#line default
#line hidden
#nullable disable
                , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Usuario.DataNascimento = __value, Usuario.DataNascimento)), 37, () => Usuario.DataNascimento);
                __builder2.AddMarkupContent(38, "\r\n            ");
                __Blazor.AprendendoBlazor.Client.Components.NovoUsuarioForm.TypeInference.CreateValidationMessage_2(__builder2, 39, 40, 
#nullable restore
#line 20 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\Components\NovoUsuarioForm.razor"
                                      () => Usuario.DataNascimento

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n\r\n    ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group");
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.AddMarkupContent(47, "<label for=\"Email\">E-mail</label>\r\n        ");
                __builder2.OpenElement(48, "div");
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(50);
                __builder2.AddAttribute(51, "class", "form-control");
                __builder2.AddAttribute(52, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\Components\NovoUsuarioForm.razor"
                                                          Usuario.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Usuario.Email = __value, Usuario.Email))));
                __builder2.AddAttribute(54, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Usuario.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n            ");
                __Blazor.AprendendoBlazor.Client.Components.NovoUsuarioForm.TypeInference.CreateValidationMessage_3(__builder2, 56, 57, 
#nullable restore
#line 28 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\Components\NovoUsuarioForm.razor"
                                      () => Usuario.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(58, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n\r\n    ");
                __builder2.AddMarkupContent(61, "<button type=\"submit\" class=\"btn btn-primary\">Salvar</button>\r\n    ");
                __builder2.OpenElement(62, "button");
                __builder2.AddAttribute(63, "type", "button");
                __builder2.AddAttribute(64, "class", "btn btn-dark");
                __builder2.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\Components\NovoUsuarioForm.razor"
                                                           () => Cancelar.InvokeAsync(false)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(66, "Cancelar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Projetos\AprendendoBlazor\AprendendoBlazor\Client\Components\NovoUsuarioForm.razor"
       
    //[Parameter]
    //public Usuario Usuario { get; set; }

    Usuario Usuario = new Usuario();

    [Parameter]
    public EventCallback<Usuario> Salvar { get; set; }

    [Parameter]
    public EventCallback<bool> Cancelar { get; set; }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.AprendendoBlazor.Client.Components.NovoUsuarioForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591