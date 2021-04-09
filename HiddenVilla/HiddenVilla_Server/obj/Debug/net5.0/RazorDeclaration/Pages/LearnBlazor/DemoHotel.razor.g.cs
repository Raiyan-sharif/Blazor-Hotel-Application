// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "E:\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
using Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/demoHotel")]
    public partial class DemoHotel : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "E:\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\DemoHotel.razor"
      
    public int SelectedRooms { get; set; } = 0;
    public string SelectedAmenity { get; set; } = "";


    List<BlazorRoom> RoomsList = new List<BlazorRoom>();
    List<BlazorAmenities> AmenitiesList = new List<BlazorAmenities>();


    protected override void OnInitialized()
    {
        base.OnInitialized();
        RoomsList.Add(new BlazorRoom()
        {
            Id = 201,
            RoomName = "Villa Suite One Bed Room",
            IsActive = true,
            Price = 399,
            RoomProps = new List<BlazorRoomProp>
    {
            new BlazorRoomProp{Id=1,Name="sq Ft", Value="330"},
            new BlazorRoomProp{Id=2,Name="Occupancy", Value="4"},
        }
        });

        RoomsList.Add(new BlazorRoom()
        {
            Id = 301,
            RoomName = "Villa Suite Two Bed Room",
            IsActive = true,
            Price = 699,
            RoomProps = new List<BlazorRoomProp>{
            new BlazorRoomProp{Id=1,Name="sq Ft", Value="150"},
            new BlazorRoomProp{Id=2,Name="Occupancy", Value="6"},
        }
        });

        AmenitiesList.Add(new BlazorAmenities
        {
            Id = 111,
            Name = "Gym",
            Description = "24x7 gym room is available"
        });

        AmenitiesList.Add(new BlazorAmenities
        {
            Id = 222,
            Name = "Swimming Pool",
            Description = "Pool room is open from 6am to 10pm."
        });

        AmenitiesList.Add(new BlazorAmenities
        {
            Id = 333,
            Name = "Free Breakfast",
            Description = "Enjoy free breakfast at out hotel."
        });
    }
    protected void RoomSelectionCounterChanged(bool isRoomSelected)
    {
        if (isRoomSelected)
        {
            SelectedRooms++;
        }
        else
        {
            SelectedRooms--;
        }
    }
    protected void AmenitySelectionChanged(string amenity)
    {
        SelectedAmenity = amenity;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591