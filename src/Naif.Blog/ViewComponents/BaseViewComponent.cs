﻿using Microsoft.AspNetCore.Mvc;
using Naif.Blog.Framework;
using Naif.Blog.Services;

namespace Naif.Blog.ViewComponents
{
    public abstract class BaseViewComponent : ViewComponent
    {
        protected BaseViewComponent(IBlogRepository blogRepository, IApplicationContext appContext)
        {
            Blog = appContext.CurrentBlog;
            BlogRepository = blogRepository;
        }

        public Models.Blog Blog { get; }

        protected IBlogRepository BlogRepository { get; set; }


    }
}
