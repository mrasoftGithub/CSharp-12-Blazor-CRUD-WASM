using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WASM;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//-- als je het uit een custom config file wilt halen (test.json i.p.v. appsettings.json):
    //var http = new HttpClient 
    //{ 
    //    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
    //};
    //builder.Services.AddScoped(sp => http);
    //using var response = await http.GetAsync("test.json");
    //using var stream = await response.Content.ReadAsStreamAsync();
    //builder.Configuration.AddJsonStream(stream);
//---

await builder.Build().RunAsync();
