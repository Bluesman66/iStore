﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using iStore.Domain.Abstract;
using iStore.Domain.Entities;
using iStore.WebUI.Models;

namespace iStore.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStoreRepository _repository;
        public int PageSize { get; set; }

        public HomeController(IStoreRepository repository)
        {
            if (repository == null) throw new ArgumentNullException("repository");
            _repository = repository;
            PageSize = 12;
        }

        public ActionResult Catalog(string category, int page = 1)
        {
            var model = new ItemsListViewModel
            {
                Items = _repository.Items
                    .Where(item => category == null || item.Category == category)
                    .OrderBy(item => item.ItemId)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize)
                    .ToList(),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null
                        ? _repository.Items.Count()
                        : _repository.Items.Count(item => item.Category == category)
                },
                CurrentCategory = category
            };

	        if (page > model.PagingInfo.TotalPages)
				model.PagingInfo.CurrentPage = model.PagingInfo.TotalPages;

			// пустая модель
            //var model = new ItemsListViewModel()
            //{
            //    Items = new List<Item>(),
            //    PagingInfo = new PagingInfo() {ItemsPerPage = 12}
            //};

            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Where()
        {
            return View();
        }

        public ActionResult Faq()
        {
            return View();
        }

        public ActionResult Contacts()
        {
            return View();
        }

        public ActionResult Cart()
        {
            return View();
        }
    }
}