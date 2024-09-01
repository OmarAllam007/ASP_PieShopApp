using PieShopApp.Models;
using Microsoft.AspNetCore.Components;

namespace PieShopApp.App.Pages
{
    public partial class PieCard
    {
        [Parameter]
        public Pie? Pie { get; set; }
    }
}
