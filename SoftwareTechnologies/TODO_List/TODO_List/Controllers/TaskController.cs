﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TODOList.Models; 

namespace TODOList.Models
{
    public class TaskController : Controller
    {
        [HttpPost]
        public IActionResult Create (Task task)
        {
            if (task == null)
            {
                return RedirectToAction("Index", "Home"); 
            }

            using (var db = new TaskDbContext())
            {
                db.Tasks.Add(task);
                db.SaveChanges(); 
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete (int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home"); 
            }

            using (var db = new TaskDbContext())
            {
                var task = db.Tasks.Find(id);

                if (task == null)
                {
                    return RedirectToAction("Index", "Home");
                }
                db.Tasks.Remove(task);
                db.SaveChanges();
            }

            return RedirectToAction("Index", "Home"); 
        }
    }
}