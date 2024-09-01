using Microsoft.AspNetCore.Mvc;
using Moq;
using PieShopApp.Controllers;
using PieShopApp.ViewModels;
using PieShopTest.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieShopTest.Controllers
{
    public class PieControllerTests 
    {
        [Fact]
        public void List_EmptyCategory_ReturnsAllPies() { 
            var mockPieRepository = RepositoryMocks.GetPieRepository();
            var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();

            var pieController = new PieController(mockPieRepository.Object, mockCategoryRepository.Object);

            var result =  pieController.List("");

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<PieListViewModel>(viewResult.ViewData.Model);

            Assert.Equal(3, model.Pies.Count());
        }
    }
}
