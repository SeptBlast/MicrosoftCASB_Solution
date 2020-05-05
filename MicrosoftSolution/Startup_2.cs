﻿// 	File Name : Startup_2.cs
// 	Auther Name : Devesh Kumar
// 	Auther EmailId : deveshkumarsep12@outlook.com
// 	Date : 05-05-2020
//
using Microsoft.AspNetCore.Builder;
<<<<<<< HEAD
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
=======
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using TodoApi.Models;
>>>>>>> e94ccf3... * Project Str. Enabled while adding Swagger 2.0

namespace ToDoApi
{
    public class Startup_2
    {
        #region snippet_ConfigureServices
        public void ConfigureServices(IServiceCollection services)
        {
<<<<<<< HEAD
=======
            //services.AddDbContext<TodoContext>(opt =>
            //    opt.UseInMemoryDatabase("TodoList"));
>>>>>>> e94ccf3... * Project Str. Enabled while adding Swagger 2.0
            services.AddControllers();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ToDoAPIs", Version = "v1" });
            });
        }
        #endregion

        #region snippet_Configure
        public void Configure(IApplicationBuilder app)
        {
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
        #endregion
    }
}
