#pragma checksum "E:\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4716b58cb85bf244219d0af69944f86cc5023bdb"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.LearnBlazor
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
#nullable restore
#line 1 "E:\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lifecycle")]
    public partial class Lifecycle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Lifecycle</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "border");
            __builder.OpenComponent<HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent.LifecycleComponent>(3);
            __builder.AddAttribute(4, "CountValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "E:\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor"
                                     currentCount

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.AddMarkupContent(6, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(7, "p");
            __builder.AddContent(8, "Current count: ");
            __builder.AddContent(9, 
#nullable restore
#line 12 "E:\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn btn-primary");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "E:\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "<br>\r\n");
            __builder.AddContent(16, 
#nullable restore
#line 15 "E:\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor"
 Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, " ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "class", "btn btn-primary");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "E:\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor"
                                                 StartCountdown

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Start Countdown");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "<br>");
#nullable restore
#line 17 "E:\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor"
 foreach(var item in EventType)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, 
#nullable restore
#line 19 "E:\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor"
     item

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(24, "<hr>");
#nullable restore
#line 21 "E:\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "E:\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor"
       
    private int currentCount = 0;
    private int Count { get; set; } = 5;
    List<string> EventType = new List<string>();

    private void IncrementCount()
    {
        currentCount++;
    }
    protected override void OnInitialized()
    {
        //base.OnInitialized();
        EventType.Add("OnInitialized Called");
    }
    protected override async Task OnInitializedAsync()
    {
        EventType.Add("OnInitializedAsync Called");
        await Task.Delay(1000);
    }

    protected override void OnParametersSet()
    {
        EventType.Add("OnParameterSet is Called");
    }
    protected override async Task OnParametersSetAsync()
    {
        EventType.Add("OnParameterSetAsync is Called");
        await Task.Delay(1000);

    }

    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            currentCount = 101;
        }
        else
        {
            currentCount = 999;
        }
        EventType.Add("OnAfterRender is Called");
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        EventType.Add("OnAfterRenderAsync is Called");
        await Task.Delay(1000);
    }

    protected override bool ShouldRender()
    {
        EventType.Add("ShouldRender is Called");
        return true;
    }
    void StartCountdown()
    {
        var timer = new Timer(TimerCallback, null, 1000, 1000);
    }
    void TimerCallback(object state)
    {
        if(Count > 0)
        {
            Count--;
            InvokeAsync(StateHasChanged);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
