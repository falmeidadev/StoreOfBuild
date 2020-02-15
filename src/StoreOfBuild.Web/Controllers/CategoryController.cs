using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StoreOfBuild.Domain.Dtos;
using StoreOfBuild.Domain.Products;
using StoreOfBuild.Web.Models;

namespace StoreOfBuild.Web.Controllers
{
  public class CategoryController : Controller
  {
    private readonly CategoryStorer _categoryStorer;

    public CategoryController(CategoryStorer categoryStorer)
    {
      _categoryStorer = categoryStorer;
    }
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult CreateOrEdit()
    {
      return View();
    }

    [HttpPost]
    public IActionResult CreateOrEdit(CategoryDto dto)
    {
      _categoryStorer.Store(dto);
      return View();
    }
  }
}
