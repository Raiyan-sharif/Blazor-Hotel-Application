#pragma checksum "E:\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\LifecycleComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "802fd7c4cb05f5a681351de237304175e299922f"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent;

#line default
#line hidden
#nullable disable
    public partial class LifecycleComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Lifecycle Child Component</h3>");
#nullable restore
#line 4 "E:\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\LifecycleComponent.razor"
 foreach (var item in EventType)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, 
#nullable restore
#line 6 "E:\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\LifecycleComponent.razor"
     item

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(2, "<hr>");
#nullable restore
#line 8 "E:\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\LifecycleComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "E:\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\LearnBlazorComponent\LifecycleComponent.razor"
       

    [Parameter]
    public int CountValue { get; set; }

    private int currentCount = 0;
    List<string> EventType = new List<string>();


    protected override void OnInitialized()
    {
        //base.OnInitialized();
        EventType.Add("Child - OnInitialized Called");
    }
    protected override async Task OnInitializedAsync()
    {
        EventType.Add("Child - OnInitializedAsync Called");
        await Task.Delay(1000);
    }

    protected override void OnParametersSet()
    {
        EventType.Add("Child - OnParameterSet is Called");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591