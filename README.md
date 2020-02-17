# aspnet-core-web-api-empty-template
Sample aspnet core web api from empty template

1. Add a HomeController class. Ensure it inherits from ControllerBase class
2. Add the following decorators     
    [ApiController]
    [Route("[controller]")] on top of the class name. 
3. In Startup.cs
      Add the line services.AddControllers(); inside 
            public void ConfigureServices(IServiceCollection services)
            
      Inside public void Configure(IApplicationBuilder app, IWebHostEnvironment env)            
      Add the line endpoints.MapControllers(); inside 
             app.UseEndpoints(endpoints => {    //code here      });
4. TODO - fix launchURL in the launchsettings.json(Properties folder) file        
5. TODO - Add functionality to accept an array of integers and return the average. Refactor this.
