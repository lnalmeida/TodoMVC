﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TodoMVC.Contexts;
using TodoMVC.Models;
using TodoMVC.Repository;

namespace TodoMVC.Controllers
{
    public class TodoController : Controller
    {
        private readonly TodoRepository _repository;

        public TodoController(TodoRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var todos = await _repository.GetAll();
            ViewData["Title"] = "Task List";
            return todos != null ? 
                          View(todos) :
                          Problem("No Data to show.");
        }

        public async Task<IActionResult> Details(int id)
        {
            var todo = await _repository.GetById(id);
            if (todo == null)
            {
                return NotFound();
            }

            return View(todo);
        }

        public IActionResult Create()
        {
             return View();
        }

        [HttpPost]
        public async Task<object> Create(Todo todo)
        {
               await _repository.Add(todo);
               return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var todo = await _repository.GetById(id);
            if (todo == null) return NotFound();
            return View(todo);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Todo todo)
        {
            await _repository.Update(id, todo);
                return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var todo = await _repository.GetById(id);
            if (todo == null) return NotFound();
            await _repository.Delete(todo.Id);
            return RedirectToAction(nameof(Index));
        }
    }
}
